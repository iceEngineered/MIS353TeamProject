using HW4SARp2.Entities;

namespace HW4SARp2.Repositories
{
    public interface ICityDetails
    {
        public Task<List<City>> GetCityDetails(int CID);
    }
}
