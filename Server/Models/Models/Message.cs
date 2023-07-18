﻿using MongoDB.Bson.Serialization.Attributes;

namespace Models.Models
{
    public class Message
    {
        [BsonId]
        public Guid MessageId { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
    }
}
