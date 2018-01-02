using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using sitenames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitenames.Services
{
    public interface ISiteRepository
    {
        IEnumerable<Site> GetSites();
        Task<Site> GetSite(int siteid);
        Task<Site> AddSite(Site newSite);
        void Commit();
        Task FeedData();
    }
    public class SiteRepository : ISiteRepository
    {
        private List<Site> _sites;
        private StopApi _StopApi;
        private string _StopApiKey; 

        public SiteRepository(IConfiguration configuration)
        {
            // Init a instance of API class.
            _StopApi = new StopApi();
            _StopApiKey= configuration["StopApiKey"];

        }
        public Task<Site> AddSite(Site newSite)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public async Task FeedData()
        {
            // Get all stops from API Async. Save it to inMemory Variable.
            _sites = await _StopApi.GetAllStopsAsync(_StopApiKey);

        }

        public Task<Site> GetSite(int siteid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Site> GetSites()
        {
            return _sites;
        }
    }
}
