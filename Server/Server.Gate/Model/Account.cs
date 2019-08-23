﻿using MongoDB.Bson.Serialization.Attributes;

namespace Server.Gate
{
    [BsonIgnoreExtraElements]
    public class AccountInfo
    {
        [BsonId]
        public string Account { get; set; }

        public string Password { get; set; }
    }
}