using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB;

public class Client : IDisposable
{
    public enum AuthTypes
    {
        None,
        APIKey,
        BearerToken
    }


    public const string VERSION = "v3";
    public const string VERSION_AS_OF_DATE = "2024-02-16";
    private const string API_BASE_ADDRESS = "https://api.themoviedb.org";


    private static readonly JsonSerializerOptions _jsonSerializerOptions = new(JsonSerializerDefaults.Web);


    private readonly REST.Client _restClient = new(new Uri(API_BASE_ADDRESS))
    {
        RetryCount = 9,
        RetryDelay = 100
    };

    private AuthTypes _authType = AuthTypes.None;
    private string _authKey = null;



    public Client() { }

    public Client(AuthTypes authType, string authKey) => SetAuth(authType, authKey);


    public void Dispose()
    {
        _restClient.Dispose();
        GC.SuppressFinalize(this);
    }



    public bool AutoThrowIfError
    {
        get => _restClient.AutoThrowIfError;
        set => _restClient.AutoThrowIfError = value;
    }

    public bool IncludeRawContentInResponse
    {
        get => _restClient.IncludeRawContentInResponse;
        set => _restClient.IncludeRawContentInResponse = value;
    }

    public int RetryCount
    {
        get => _restClient.RetryCount;
        set => _restClient.RetryCount = value;
    }

    public int RetryDelay
    {
        get => _restClient.RetryDelay;
        set => _restClient.RetryDelay = value;
    }

    public AuthTypes AuthType => _authType;

    public string AuthKey => _authKey;

    public IEndpoints Endpoints => new Endpoints(this);



    public void SetAuth(AuthTypes authType, string authKey)
    {
        _authType = authType;
        _authKey = authKey;
    }

    private static string AddQueryParameter(string subUrl, string key, string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return subUrl;

        subUrl += subUrl.Contains('?') ? '&' : '?';
        return subUrl + $"{key}={Uri.EscapeDataString(value)}";
    }

    private static string AddQueryParameters(string subUrl, IReadOnlyDictionary<string, object> queryParams)
    {
        if (queryParams != null)
            foreach (var kvp in queryParams)
                if (kvp.Value != null)
                    subUrl = AddQueryParameter(subUrl, kvp.Key, kvp.Value.ToString());
        return subUrl;
    }

    internal Task<Response<T>> GetAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add("Authorization", "Bearer " + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, "api_key", _authKey);
        return _restClient.GetAsync<T>(AddQueryParameters(subUrl, queryParams), headers, cancellationToken);
    }

    internal Task<Response<T>> PostAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, object data, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add("Authorization", "Bearer " + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, "api_key", _authKey);
        return _restClient.PostAsync<T>(AddQueryParameters(subUrl, queryParams), data, headers, cancellationToken);
    }

    internal Task<Response<T>> DeleteAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, object data, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add("Authorization", "Bearer " + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, "api_key", _authKey);
        return _restClient.DeleteAsync<T>(AddQueryParameters(subUrl, queryParams), headers, data, cancellationToken);
    }

    internal Task<Response<T>> DeleteAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, CancellationToken cancellationToken) =>
       DeleteAsync<T>(subUrl, queryParams, null, cancellationToken);
}