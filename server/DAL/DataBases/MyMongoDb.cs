using MongoDB.Driver;

namespace DAL.DataBases
{
    class MyMongoDb
    {
        public IMongoDatabase Client;

        public MyMongoDb(string database)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://idoBackgammon:<password>@cluster0.svoxwoo.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            Client = client.GetDatabase(database);
        }
    }
}
