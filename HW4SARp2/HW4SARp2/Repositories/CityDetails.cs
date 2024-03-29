using HW4SARp2.Data;
using HW4SARp2.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HW4SARp2.Repositories
{
    public class CityDetails : ICityDetails
    {
        private readonly DbContextClass _dbContextClass;
        public CityDetails(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<City>> GetCityDetails(int CID)
        {
            var param = new SqlParameter("@CID", CID);
            var cityDeets = await Task.Run(() => _dbContextClass.City.FromSqlRaw("exec spGetCityDetails @CID", param).ToListAsync());
            return cityDeets;
        }
    }
}
