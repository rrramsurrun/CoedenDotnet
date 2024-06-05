using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coeden.Models
{
  public class Tree
  {

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("objectid")]
    public int? ObjectId { get; set; }
    [BsonElement("borough")]
    public string Borough { get; set; }
    [BsonElement("tree_name")]
    public string TreeName { get; set; }
    [BsonElement("taxon_name")]
    public string Taxon { get; set; }
    [BsonElement("common_name")]
    public string CommonName { get; set; }
    [BsonElement("genus_name")]
    public string Genus { get; set; }
    [BsonElement("longitude")]
    public double Longitude { get; set; }
    [BsonElement("latitude")]
    public double Latitude { get; set; }

    public Tree(string id, string borough, string treeName, string taxon, string commonName, string genus, double longitude, double latitude)
    {
      this.Id = id;
      this.Borough = borough;
      this.TreeName = treeName;
      this.Taxon = taxon;
      this.CommonName = commonName;
      this.Genus = genus;
      this.Longitude = longitude;
      this.Latitude = latitude;

    }
    public Tree(string borough, string treeName, string taxon, string commonName, string genus, double longitude, double latitude)
    {
      this.Borough = borough;
      this.TreeName = treeName;
      this.Taxon = taxon;
      this.CommonName = commonName;
      this.Genus = genus;
      this.Longitude = longitude;
      this.Latitude = latitude;

    }
  }
}