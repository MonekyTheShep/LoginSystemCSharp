using Microsoft.VisualBasic;
using MongoDB.Driver;
namespace loginSystem
{
    public class HandleMongoDB : IDatabaseHandling
    {
        string password;
              
        /// <summary>connect to a mongodb database</summary>

        public HandleMongoDB(string password)
        {
            this.password = password;
        }
        public void connect() 
        {
            
        }
        public void disconnect()
        {
            
        }
    }    
}
