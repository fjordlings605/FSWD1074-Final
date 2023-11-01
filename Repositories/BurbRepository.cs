using burble_api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace burble_api.Repositories;

public class BurbRepository : IBurbRepository 
{
    private readonly IMongoCollection<Burble> _burbs;

    public BurbRepository(IOptions<BurbDatabaseSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        var database = client.GetDatabase(settings.Value.DatabaseName);

        _burbs = database.GetCollection<Burble>(settings.Value.BurbCollectionName);
    }

    public async Task<IEnumerable<Burble>> GetAllBurbs()
    {
        var allBurbs = await _burbs.FindAsync(Burble => true);
        return allBurbs.ToList();
    }

    public async Task<Burble?> GetBurbById(string burbId)
    {
        var burbFound = await _burbs.FindAsync<Burble>(burb => burb.BurbId == burbId);
        return burbFound.FirstOrDefault();
    }

    public async Task<IEnumerable<Burble>> GetBurbsByUsername(string username)
    {
        var userBurbs = await _burbs.FindAsync<Burble>(burb => burb.Username == username);
        return userBurbs.ToList();
    }

    public async Task<Burble> CreateBurb(Burble newBurb)
    {
        await _burbs.InsertOneAsync(newBurb);
        return newBurb;
    }

    public async Task<Burble> UpdateBurb(Burble editBurb)
    {
        await _burbs.ReplaceOneAsync(burb => burb.BurbId == editBurb.BurbId, editBurb);
        return editBurb;
    }

    public async Task DeleteBurbById(string burbId)
    {
        await _burbs.DeleteOneAsync(burb => burb.BurbId == burbId);
    }
}