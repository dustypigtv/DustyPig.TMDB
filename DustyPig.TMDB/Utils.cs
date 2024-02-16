using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace DustyPig.TMDB;

public static class Utils
{
    public const string SECURE_IMAGE_ROOT = "https://image.tmdb.org/t/p/";

    internal static string GetEnumDescription<T>(this T value) where T : Enum
    {
        Type type = value.GetType();
        if (!type.IsEnum)
            throw new ArgumentException("EnumerationValue must be of Enum type", nameof(value));

        var flags = type.GetCustomAttribute<FlagsAttribute>(false);
        if(flags == null)
        {
            MemberInfo[] memberInfos = type.GetMember(value.ToString());
            if (memberInfos != null && memberInfos.Length > 0)
            {
                var description = memberInfos[0].GetCustomAttribute<DescriptionAttribute>(false);
                if (description != null)
                    return description.Description;
            }
            return value.ToString();
        }
        else
        {
            var valueAsEnum = value as Enum;
            var retStrings = new List<string>();
            foreach (Enum enumValue in Enum.GetValues(type))
                if (valueAsEnum.HasFlag(enumValue))
                {
                    MemberInfo[] memberInfos = type.GetMember(enumValue.ToString());
                    if (memberInfos != null && memberInfos.Length > 0)
                    {
                        var description = memberInfos[0].GetCustomAttribute<DescriptionAttribute>(false);
                        if (description == null)
                            retStrings.Add(enumValue.ToString());
                        else
                            retStrings.Add(description.Description);
                    }
                    else
                    {
                        retStrings.Add(enumValue.ToString());
                    }
                }
            var ret = string.Join(',', retStrings);
            if (string.IsNullOrWhiteSpace(ret))
                ret = null;
            return ret;
        }
    }



    internal static DateOnly? TmdbToDateOnly(this string self)
    {
        if(DateOnly.TryParse(self, out DateOnly dateOnly))
            return dateOnly;
        return null;
    }

    internal static string DateOnlyToTmdb(this DateOnly? self) => self?.ToString("yyyy-MM-dd");

    
    
    internal static DateTime? TmdbToDateTime(this string self)
    {
        if (DateTime.TryParse(self, out DateTime dateTime))
            return dateTime;
        return null;
    }
    
    internal static string DateTimeToTmdb(this DateTime? self) => self?.ToUniversalTime().ToString("yyyy-MM-dd hh\\:mm\\:ss UTC");



    public static string GetFullImageUrl(string path, string size)
    {
        if (string.IsNullOrWhiteSpace(path))
            return null;

        path = path.Trim();
        if (!path.StartsWith('/'))
            path = '/' + path;

        return SECURE_IMAGE_ROOT + size + path;
    }

    public static string GetFullSizeImageUrl(string path) => GetFullImageUrl(path, "original");
}
