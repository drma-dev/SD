﻿using SD.Shared.Core.Models;
using SD.Shared.Model.List.Imdb;

namespace SD.Shared.Models.List.Imdb
{
    public class MostPopularDataCache : CacheDocument<MostPopularData>
    {
        public MostPopularDataCache()
        { }

        public MostPopularDataCache(MostPopularData data, string key) : base(key, data, ttlCache.one_day)
        { }
    }
}