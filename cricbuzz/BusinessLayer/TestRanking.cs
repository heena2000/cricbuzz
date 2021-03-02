using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cricbuzzz.BusinessLayer
{
    public class TestRanking
    {
        public int Id { get; set; }

        public string PlayerName { get; set; }

        public int Rating { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
