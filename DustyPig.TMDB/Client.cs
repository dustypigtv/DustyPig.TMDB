using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB;

public class Client
{
    public enum AuthTypes
    {
        None,
        APIKey,
        BearerToken
    }


    public const string VERSION = "v3";
    public const string VERSION_AS_OF_DATE = "2025-09-13";
    private const string API_BASE_ADDRESS = "https://api.themoviedb.org";
    
    
    private const string AUTHORIZATION_HEADER = "Authorization";
    private const string BEARER_PREFIX = "Bearer ";
    private const string API_KEY_QUERY_PARAM = "api_key";

    private readonly REST.Client _restClient;


    private AuthTypes _authType = AuthTypes.None;
    private string _authKey = null;



    public Client(HttpClient httpClient = null, AuthTypes authType = AuthTypes.None, string authKey = null, ILogger<Client> logger = null)
    {
        _restClient = new(httpClient ?? new(), logger)
        {
            BaseAddress = new Uri(API_BASE_ADDRESS)
        };
        SetAuth(authType, authKey);
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

    public ushort RetryCount
    {
        get => _restClient.RetryCount;
        set => _restClient.RetryCount = value;
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

    internal Task<Response> GetAsync(string subUrl, IReadOnlyDictionary<string, object> queryParams, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add(AUTHORIZATION_HEADER, BEARER_PREFIX + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, API_KEY_QUERY_PARAM, _authKey);
        return _restClient.GetAsync(AddQueryParameters(subUrl, queryParams), headers, cancellationToken);
    }

    internal Task<Response<T>> GetAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add(AUTHORIZATION_HEADER, BEARER_PREFIX + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, API_KEY_QUERY_PARAM, _authKey);
        return _restClient.GetAsync<T>(AddQueryParameters(subUrl, queryParams), headers, cancellationToken);
    }

    internal Task<Response<T>> PostAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, object data, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add(AUTHORIZATION_HEADER, BEARER_PREFIX + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, API_KEY_QUERY_PARAM, _authKey);
        return _restClient.PostAsync<T>(AddQueryParameters(subUrl, queryParams), data, headers, cancellationToken);
    }

    internal Task<Response<T>> DeleteAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, object data, CancellationToken cancellationToken)
    {
        Dictionary<string, string> headers = [];
        if (_authType == AuthTypes.BearerToken)
            headers.Add(AUTHORIZATION_HEADER, BEARER_PREFIX + _authKey);
        else
            subUrl = AddQueryParameter(subUrl, API_KEY_QUERY_PARAM, _authKey);
        return _restClient.DeleteAsync<T>(AddQueryParameters(subUrl, queryParams), headers, data, cancellationToken);
    }

    internal Task<Response<T>> DeleteAsync<T>(string subUrl, IReadOnlyDictionary<string, object> queryParams, CancellationToken cancellationToken) =>
       DeleteAsync<T>(subUrl, queryParams, null, cancellationToken);
}