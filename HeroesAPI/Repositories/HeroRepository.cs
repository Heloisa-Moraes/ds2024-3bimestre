using HeroesAPI.Collections;
using MongoDB.Driver;

namespace HeroesAPI.Repositories;
public class HeroRepository : IHeroRepository
{   
    private readonly IMongoCollection<Heroi> _collection; 
    public HeroRepository(IMongoDatabase mongoDatabase)
    {
        _collection = mongoDatabase.GetCollection<Heroi>("herois");
    }

    public async Task CreateAsync(Heroi hero) => await _collection.InsertOneAsync(hero);

    public async Task DeleteAsync(string id) => await _collection.DeleteOneAsync(h => h.Id == id);

    public async Task<List<Heroi>> GetAllAsync() => await _collection.Find(h => true).ToListAsync();

    public async Task<Heroi> GetByIdAsync(string id) => await _collection.Find(h => h.Id == id).FirstOrDefaultAsync();

    public async Task UpdateAsync(Heroi hero) => await _collection.ReplaceOneAsync(h => h.Id == hero.Id, hero);
}
