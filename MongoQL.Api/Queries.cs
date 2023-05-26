namespace MongoQL.Api.Queries;

using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoQL.Api.Models;

public class Queries
{
	[UsePaging(MaxPageSize = 5, IncludeTotalCount = true)]
	[UseFiltering]
	public IQueryable<Assumption<ActualOrForecast>> GetActualForecast([FromServices] MongoDBContext mongo) =>
		mongo.Database.GetCollection<Assumption<ActualOrForecast>>("assumptions").AsQueryable().Where(w => w.AssumptionKey == "production_vs_fit");


	[UsePaging(MaxPageSize = 5, IncludeTotalCount = true)]
	[UseFiltering]
	public IQueryable<TagModel> GetTags([FromServices] MongoDBContext mongo) =>
		mongo.TagsCollection.AsQueryable();
}
