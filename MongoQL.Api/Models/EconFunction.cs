namespace MongoQL.Api.Models;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

[BsonIgnoreExtraElements]
public class Assumption<T>
{
	[BsonId]
	[BsonElement("_id")]
	[BsonRepresentation(BsonType.ObjectId)]
	public string Id { get; init; }

	[BsonElement("assumptionKey")]
	public string AssumptionKey { get; init; }

	[BsonElement("copiedFrom")]
	public string CopiedFrom { get; init; }

	[BsonElement("unique")]
	public bool Unique { get; init; }

	[BsonRepresentation(BsonType.ObjectId)]
	[BsonElement("well")]
	public string WellID { get; init; }

	[BsonRepresentation(BsonType.ObjectId)]
	[BsonElement("scenario")]
	public string ScenarioID { get; init; }

	[BsonElement("createdBy")]
	[BsonRepresentation(BsonType.ObjectId)]
	public string CreatedBy { get; init; }

	[BsonElement("CreatedAt")]
	public DateTime createdAt { get; init; }

	[BsonElement("UpdatedAt")]
	public DateTime updatedAt { get; init; }

	[IsProjected(false)]
	[BsonElement("options")]
	public Dictionary<string, object> Options { get; init; }

	[IsProjected(true)]
	[BsonElement("econ_function")]
	public T EconFunction { get; init; }
}
