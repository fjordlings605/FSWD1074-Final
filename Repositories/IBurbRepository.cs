using burble_api.Models;
using System.Collections.Generic;

namespace burble_api.Repositories;

public interface IBurbRepository
{
    Task<IEnumerable<Burble>> GetAllBurbs();
    Task<Burble> GetBurbById(string burbId);
    Task<IEnumerable<Burble>> GetBurbsByUsername(string username);

    Task<Burble> CreateBurb(Burble burb);

    Task<Burble> UpdateBurb(Burble burb);

    Task DeleteBurbById(string burbId);

}