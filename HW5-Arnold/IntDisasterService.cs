using MISTeamProjectAPI.Entities;

namespace MISTeamProjectAPI.Repositories
{
    public interface IntDisasterService
    {
        public Task<List<Disaster>> GetCityDisasters(int CID);
        public Task<int> AddDisaster(Disaster disaster);
    }
}
