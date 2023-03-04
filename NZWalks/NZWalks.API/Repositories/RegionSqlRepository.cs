using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Data;
using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Repositories
{
    public class RegionSqlRepository : IRegionRepository
    {
        private readonly NZWalksDbContext _NZWalksDbContext;
        public RegionSqlRepository(NZWalksDbContext NZWalksDbContext)
        {
            this._NZWalksDbContext = NZWalksDbContext;
        }
        public async Task <IEnumerable<Region>> Getallsync()
        {
            return   await _NZWalksDbContext.Regions.ToListAsync();
        }
    }
}
