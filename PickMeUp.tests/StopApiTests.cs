using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sitenames.Entities;
using sitenames.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace sitenames.tests
{
    [TestClass]
    public class StopApiTests
    {
        public static IConfigurationRoot Configuration { get; set; }

        [TestMethod]
        public async Task GetDataFromApi()
        {

            var stopapi = new StopApi();

            //TODO: Load API-Key via configuration file.
            //TODO: Create TestMethod for API-Key test.
            string apikey = "0a9471667f194xxxxxxxxxxxxx";
            var result = await stopapi.GetAllStopsAsync(apikey);

            //-- Act
            var expected = result.Count;
            foreach (Site R in result)
            {
                System.Console.WriteLine(R.SiteName);
            }

            //-- Assert
            Assert.IsNotNull(expected);
        }
        [TestMethod]
        public void VerifyCreateSiteObject()
        {

            //-- Arrange
            DateTime thisDay = DateTime.Today;
            var site = new Site
            {
                SiteName = "test",
                SiteId = 1,
                StopAreaNumber = 1,
                ExistsFromDate = thisDay,
                LastModifiedUtcDateTime = thisDay
            };

            //-- Act


            //-- Assert
            Assert.AreEqual(site.SiteName, "test");
            Assert.AreEqual(site.SiteId, 1);
            Assert.AreEqual(site.StopAreaNumber, 1);
            Assert.AreEqual(site.ExistsFromDate, thisDay);
            Assert.AreEqual(site.LastModifiedUtcDateTime, thisDay);
        }
        [TestMethod]
        public void VerifySiteResponseDataObject()
        {

            //-- Arrange
            DateTime thisDay = DateTime.Today;
            var siteResponseData = new SiteResponseData
            {
                Result = new List<Site>
                {
                    new Site
                    {
                        SiteName = "test",
                        SiteId = 1,
                        StopAreaNumber = 1,
                        ExistsFromDate = thisDay,
                        LastModifiedUtcDateTime = thisDay
                    }
            },
                Type = "1",
                Version = "1"
            };

            //-- Act


            //-- Assert
            Assert.AreEqual(siteResponseData.Type, "1");
            Assert.AreEqual(siteResponseData.Version, "1");
        }
    }


}
