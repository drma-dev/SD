﻿using Microsoft.Extensions.Caching.Memory;
using SD.WEB.Shared;

namespace SD.WEB.Modules.Profile.Core
{
    public class WishListApi(IHttpClientFactory factory, IMemoryCache memoryCache) : ApiCore<WishList>(factory, memoryCache, "WishList")
    {
        private struct Endpoint
        {
            public const string Get = "wishlist/get";

            public static string Add(MediaType? type) => $"wishlist/add/{type}";

            public static string Remove(MediaType? type, string id) => $"wishlist/remove/{type}/{id}";
        }

        public async Task<WishList?> Get(bool IsUserAuthenticated, RenderControlCore<WishList?>? core, string? id = null)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return await GetAsync($"{Endpoint.Get}?id={id}", core);
            }
            else if (IsUserAuthenticated)
            {
                return await GetAsync(Endpoint.Get, core);
            }
            else
            {
                return new();
            }
        }

        public async Task<WishList?> Add(MediaType? mediaType, WishListItem item)
        {
            ArgumentNullException.ThrowIfNull(mediaType);
            ArgumentNullException.ThrowIfNull(item);

            return await PostAsync(Endpoint.Add(mediaType), null, item);
        }

        public async Task<WishList?> Remove(MediaType? mediaType, string? id)
        {
            ArgumentNullException.ThrowIfNull(mediaType);
            ArgumentNullException.ThrowIfNull(id);

            return await PostAsync(Endpoint.Remove(mediaType, id), null, (WishList?)null);
        }
    }
}