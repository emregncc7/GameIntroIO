using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntroIO.Entities
{
    class Campaigning
    {
        public int Id { get; set; }
        public string CampaigningName { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
