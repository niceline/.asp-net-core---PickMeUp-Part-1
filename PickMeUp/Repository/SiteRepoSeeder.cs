using Microsoft.Extensions.DependencyInjection;
using sitenames.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitenames.Repository
{
    public class SiteRepoSeeder
    {
        public SiteRepoSeeder()
        {

        }
        public async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //Based on EF team's example at https://github.com/aspnet/MusicStore/blob/dev/samples/MusicStore/Models/SampleData.cs
                var siteRepo = serviceScope.ServiceProvider.GetService<ISiteRepository>();
                await siteRepo.FeedData();
            }
        }
    }
}
