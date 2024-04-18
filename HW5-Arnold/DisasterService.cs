using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using MISTeamProjectAPI.Entities;
using MISTeamProjectAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace MISTeamProjectAPI.Repositories

{

    public class DisasterService : IntDisasterService
    {
        private readonly DbContextClass _dbContext;
        public DisasterService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Disaster>> GetCityDisasters(int CID)
        {
            var param = new SqlParameter("@CID", CID);
            var DisasterDetails = await Task.Run(() => _dbContext.Disaster.FromSqlRaw("spGetDisasterEventsByCity @CID", param).ToListAsync());
            return DisasterDetails;
        }

        public async Task<int> AddDisaster(Disaster disaster)
        {
            var CID = new SqlParameter("@CID", disaster.CID);
            var NDType = new SqlParameter("@NDType", disaster.NDType);
            var NDDate = new SqlParameter("@NDDate", disaster.NDDate);

            var DisasterDetails = await Task.Run(() => _dbContext.Database.ExecuteSqlRaw("spAddNatDisaster @CID, @NDType, @NDDate", CID, NDType, NDDate));
            return DisasterDetails;
        }
    }
    }
