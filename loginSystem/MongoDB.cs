using MongoDB.Driver;
namespace loginSystem
{
    public class HandleMongoDB : IDatabaseHandling
    {
        string client;
        string database;
        string collection;
              
        /// <summary>connect to a mongodb database</summary>
        /// <param name="client">The database client</param>
        /// <param name="database">The database you want to look through.</param>
        /// <param name="collection">The collections in the database you want to look through</param>

        public HandleMongoDB(string client = null, string database = null, string collection = null)
        {
            this.client = client;
            this.database = database;
            this.collection = collection;
        }
        public void connect() 
        {
            var _client = new MongoClient(client);  
            var _database = _client.GetDatabase(database);
            var _collection = _database.GetCollection<Task>(collection);
        }

        // no disconnect function in mongodb
        public void disconnect(){}
    }    
}
