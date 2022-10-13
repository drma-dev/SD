﻿using Blazored.SessionStorage;
using SD.Shared.Model;
using SD.WEB.Core;

namespace SD.WEB.Api
{
    public static class MyProvidersApi
    {
        private struct Endpoint
        {
            public const string Get = "MyProviders/Get";
            public const string Post = "MyProviders/Post";
        }

        public static async Task<MyProviders?> MyProviders_Get(this HttpClient http, ISyncSessionStorageService? storage)
        {
            return await http.Get<MyProviders>(Endpoint.Get, false, storage);
        }

        public static async Task<HttpResponseMessage> MyProviders_Post(this HttpClient http, MyProviders? obj, ISyncSessionStorageService? storage)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            return await http.Post(Endpoint.Post, false, obj, storage, Endpoint.Get);
        }
    }
}