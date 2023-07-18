using MongoDB.Driver;

namespace DAL.Database
{
    class MyMongoDB
    {
        public IMongoDatabase Client;

        public MyMongoDB(string database)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://user:<password>@cluster0.svoxwoo.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            Client = client.GetDatabase(database);          
        }
    }
}
