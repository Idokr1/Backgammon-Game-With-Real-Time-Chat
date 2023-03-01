using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DAL.Models
{
    public class User
    {
        [BsonId]
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConnectionId { get; set; }
        public string PlayWith { get; set; }
        public Chat CurrentChat { get; set; }
    }
}
