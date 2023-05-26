namespace MongoQL.Api.Models;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

[BsonIgnoreExtraElements]
public class TagModel
{
	[BsonId]
	[BsonRepresentation(BsonType.ObjectId)]
	public string _id { get; set; }
	public string name { get; set; }
	public string description { get; set; }
	public int color { get; set; }
	[BsonRepresentation(BsonType.ObjectId)]
	public string createdBy { get; set; }
	public DateTime createdAt { get; set; }
	public DateTime updatedAt { get; set; }
}
