using dotnetAPI.Data;
using dotnetAPI.DTO;
using dotnetAPI.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;


namespace dotnetAPI.Repositories {
    public class RegionRepositoryImpl : RegionRepository {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepositoryImpl(NZWalksDbContext nZWalksDbContext) {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<Region> AddRegion(Region region) {

            //region.Id = null;
            await nZWalksDbContext.Regions.AddAsync(region);

            await nZWalksDbContext.SaveChangesAsync();
            return region;
        }

        public async Task<bool> DeleteRegion(int id) {
            var region = await GetById(id);
            if (region == null) {
                return false;
            }
            nZWalksDbContext.Regions.Remove(region);
            await nZWalksDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Region>> GetAll() {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetById(int id) {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region> UpdateRegion(Region region) {

            var find = await GetById(region.Id);

            if (find == null) {
                return null;
            }

            find.Code = region.Code;
            find.Name = region.Name;
            find.Area = region.Area;
            find.Lat = region.Lat;
            find.Long = region.Long;
            find.Population = region.Population;




            nZWalksDbContext.Regions.Update(find);
            await nZWalksDbContext.SaveChangesAsync();


            return find;

        }
    }
}
