using sitenames.Entities;
using sitenames.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sitenames.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<Site> Sites { get; set; }
    }
}
