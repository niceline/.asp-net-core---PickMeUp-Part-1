using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitenames.Entities
{
    public class Site
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int StopAreaNumber { get; set; }
        public DateTime LastModifiedUtcDateTime { get; set; }
        public DateTime ExistsFromDate { get; set; }
    }

    public class SiteResponseData
    {
        public string Version { get; set; }
        public string Type { get; set; }
        public List<Site> Result { get; set; }
    }

    public class SiteResponse
    {
        public int StatusCode { get; set; }
        public object Message { get; set; }
        public int ExecutionTime { get; set; }
        public SiteResponseData ResponseData { get; set; }
    }
}
