using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DAL.Models
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
