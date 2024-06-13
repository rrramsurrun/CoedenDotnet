using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace portfolio.Coeden.Models
{
  public class Species
  {
    public Species(string speciesName, string description, string imgArray)
    {
      SpeciesName = speciesName;
      Description = description;
      ImageArray = imgArray;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [JsonIgnore]
    public string? Id { get; set; }
    [BsonElement("species")]
    public string SpeciesName { get; set; }
    [BsonElement("description")]
    public string Description { get; set; }
    [BsonElement("images")]
    public string ImageArray { get; set; }

  }
}