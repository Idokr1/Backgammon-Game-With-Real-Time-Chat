using MongoDB.Bson.Serialization.Attributes;

namespace Models.Models
{
    public class Chat
    {
        [BsonId]
        public Guid ChatId { get; set; }
        public string[] Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
