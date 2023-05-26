using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoQL.Api.Models;

namespace MongoQL.Api
{
    public class MongoDBContext
    {
		public readonly IMongoDatabase Database;
        public readonly IMongoCollection<TagModel> TagsCollection;
		public readonly IMongoCollection<Assumption<Dictionary<string, object>>> AssumptionsCollection;

        public MongoDBContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            var settings = MongoClientSettings.FromConnectionString(mongoDBSettings.Value.ConnectionURI);
            settings.LinqProvider = LinqProvider.V3;

            var client = new MongoClient(settings);
            Database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);

            TagsCollection = Database.GetCollection<TagModel>("tags");
			AssumptionsCollection = Database.GetCollection<Assumption<Dictionary<string, object>>>("assumptions");
        }
    }
}
