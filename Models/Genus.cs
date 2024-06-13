using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace portfolio.Coeden.Models
{
  public class Genus
  {
    public Genus(string genusName, string description)
    {
      GenusName = genusName;
      Description = description;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [JsonIgnore]
    public string? Id { get; set; }
    [BsonElement("genus")]
    public string GenusName { get; set; }
    [BsonElement("description")]
    public string Description { get; set; }

  }
}