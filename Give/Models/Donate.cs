using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Give.Models
{
    public class Donate
    {
        [Key]
        public int ID { get; set; }
        public Dictionary<int, string> DonationType { get; set; }
        public Donate()
        {
            DonationType = new Dictionary<int, string>()
            {
                {0, "Cash Donation"},
                {1, "Item Donation" }
            };
        }
        public double CashDonation { get; set; }
        public string ItemDonation { get; set; }
        public string GiverName { get; set; }
    }
}