namespace MongoQL.Api.Models;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

[BsonIgnoreExtraElements]
public class ActualOrForecast
{
	[BsonElement("production_vs_fit_model")]
	public ActualOrForecastEconModel Wrapper { get; init; }
}

[BsonIgnoreExtraElements]
public class ActualOrForecastEconModel 
{
	[BsonElement("ignore_hist_prod")]
	public string? IgnoreHistoryProd { get; init; }

	[BsonElement("replace_actual")]
	public ReplaceConfig ReplaceActual { get; init; }
}

[BsonIgnoreExtraElements]
public class ReplaceConfig 
{
	[BsonElement("oil")]
	public ReplaceOption Oil { get; init; }

	[BsonElement("gas")]
	public ReplaceOption Gas { get; init; }

	[BsonElement("water")]
	public ReplaceOption Water { get; init; }
}

[BsonIgnoreExtraElements]
public class ReplaceOption
{
	[BsonElement("never")]
	public string? Never { get; init; }

	[BsonElement("as_of_date")]
	public string? AsOfDate { get; init; }

	[BsonElement("date")]
	public DateTime? Date { get; init; }
}

