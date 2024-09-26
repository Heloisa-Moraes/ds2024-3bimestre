
using HeroesAPI.Collections;

namespace HeroesAPI.Repositories
{
    public interface IHeroRepository
    {
        Task<List<Heroi>> GetAllAsync();
        Task<Heroi> GetByIdAsync(string id);
        Task CreateAsync(Heroi hero);
        Task Updatesync(Heroi hero);
        Task DeleteAsync(string id);
    }
}
