using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cricbuzzz.BusinessLayer
{
    public class Tour
    {
        public int Id { get; set; }

        public string TourName { get; set; }

        public string Description { get; set; }

        public string Period { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
