using System;
using Microsoft.Extensions.Options;

namespace MongoDbCache
{
    public class MongoDbCacheOptions : IOptions<MongoDbCacheOptions>
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; } = "caching";
        public string CollectionName { get; set; } = "appCache";
        public TimeSpan? ExpiredScanInterval { get; set; }

        MongoDbCacheOptions IOptions<MongoDbCacheOptions>.Value => this;
    }
}