using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coeden.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using portfolio.Coeden.Models;

namespace Coeden.Services
{
  public class TreeService
  {
    private readonly IMongoCollection<Tree> _treeCollection;
    private readonly IMongoCollection<Genus> _genusCollection;
    private readonly IMongoCollection<Species> _speciesCollection;
    public TreeService(IOptions<TreeStoreDatabaseSettings> treeStoreDatabaseSettings)
    {
      var mongoClient = new MongoClient(
        treeStoreDatabaseSettings.Value.ConnectionString);
      var mongoDatabase = mongoClient.GetDatabase(treeStoreDatabaseSettings.Value.DatabaseName);
      _treeCollection = mongoDatabase.GetCollection<Tree>(treeStoreDatabaseSettings.Value.TreesCollectionName);
      _genusCollection = mongoDatabase.GetCollection<Genus>(treeStoreDatabaseSettings.Value.GenusCollectionName);
      _speciesCollection = mongoDatabase.GetCollection<Species>(treeStoreDatabaseSettings.Value.SpeciesCollectionName);

    }

    public async Task<Tree> GetSingleTree() => await _treeCollection.Find(_ => true).FirstAsync();

    public async Task<List<Tree>> GetTreesByBounds(double N, double S, double E, double W)
    {
      return await _treeCollection.Find(tree => tree.Latitude >= S && tree.Latitude <= N && tree.Longitude <= E && tree.Longitude >= W).ToListAsync();
    }

    public async Task<Genus> GetGenus(string genusName) => await _genusCollection.Find(x => x.GenusName.Equals(genusName, StringComparison.OrdinalIgnoreCase)).FirstOrDefaultAsync();
    public async Task<Species> GetSpecies(string speciesName) => await _speciesCollection.Find(x => x.SpeciesName.Equals(speciesName, StringComparison.OrdinalIgnoreCase)).FirstOrDefaultAsync();


    // public async Task<Tree?> GetAsync(string id) =>
    // await _treeCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    // public async Task<Tree?> GetAsyncById(char treeId) =>
    // await _treeCollection.Find(x => x.Id.Contains(treeId)).FirstOrDefaultAsync();

    // public async Task<Tree> CreateAsync(Tree newTree)
    // {
    //   await _treeCollection.InsertOneAsync(newTree);
    //   return newTree;
    // }

    // public async Task UpdateAsync(string id, Tree updatedTree) =>
    //     await _treeCollection.ReplaceOneAsync(x => x.Id == id, updatedTree);

  }
}