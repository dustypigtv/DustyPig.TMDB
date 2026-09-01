using DustyPig.TMDB.Models.Common;
using System.Collections;
using System.Reflection;
using System.Text;

namespace TestsProject;

static class AdditionalPropertiesChecker
{
    public static void Check(object obj)
    {
        HashSet<object> visited = [];
        Dictionary<string, HashSet<string>> missing = [];
        CheckProperties(obj, visited, missing);
        if (missing.Count == 0)
            return;

        StringBuilder msg = new();
        msg.AppendLine();
        msg.AppendLine("\tMissing properties:");
        foreach (string key in missing.Keys)
        {
            msg.AppendLine("\t\t" + key + ':');
            foreach (var prop in missing[key])
                msg.AppendLine("\t\t\t" + prop);
        }

        throw new Exception(msg.ToString());
    }

    private static void CheckProperties(object obj, HashSet<object> visited, Dictionary<string, HashSet<string>> missing)
    {
        if (obj == null || !visited.Add(obj))
            return;

        if (obj is ModelBase modelBase)
        {
            if (modelBase.AdditionalProperties?.Count > 0)
            {
                string typeKey = obj.GetType().Namespace + '.' + obj.GetType().Name;
                missing.TryAdd(typeKey, []);
                foreach (var nameKey in modelBase.AdditionalProperties.Keys)
                    missing[typeKey].Add(nameKey);
            }
        }

        foreach (var prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var value = prop.GetValue(obj);
            if (value is not null)
            {
                if (value.GetType() != typeof(string) && value is IEnumerable enumerable)
                {
                    foreach (var subValue in enumerable)
                    {
                        if (IsComplexType(subValue.GetType()))
                            CheckProperties(subValue, visited, missing);
                    }
                }
                else if (IsComplexType(prop.PropertyType))
                {
                    CheckProperties(value, visited, missing);
                }
            }
        }
    }

    //public static IEnumerable<PropertyInfo> FindPropertiesImplementingInterface(
    //    object rootType,
    //    Type targetInterface,
    //    HashSet<Type> visited = null)
    //{
    //    visited ??= [];

    //    // Prevent infinite loops on circular references
    //    if (!visited.Add(rootType.GetType()))
    //        yield break;

    //    foreach (var prop in rootType.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
    //    {
    //        // Check if the property's type implements the interface
    //        if (targetInterface.IsAssignableFrom(prop.PropertyType))
    //        {
    //            yield return prop;
    //        }

    //        // If the property is a complex object (not a primitive, string, or collection), dive deeper
    //        if (IsComplexType(prop.PropertyType))
    //        {
    //            foreach (var subProp in FindPropertiesImplementingInterface(prop.PropertyType, targetInterface, visited))
    //            {
    //                yield return subProp;
    //            }
    //        }
    //    }
    //}

    private static bool IsComplexType(Type type)
    {
        return type.IsClass &&
               type != typeof(string) &&
               !type.IsArray &&
               !typeof(System.Collections.IEnumerable).IsAssignableFrom(type);
    }
}
