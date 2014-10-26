﻿using System;

namespace MongoDBOutputCache
{
    [Serializable]
    internal class CacheItem
    {
        public DateTime CreatedDate { get; set; }
        public DateTime Expiration { get; set; }
        public string Id { get; set; }
        public byte[] Item { get; set; }
    }
}