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
        public string DonationType { get; set; }
        public double CashDonation { get; set; }
        public string ItemDonation { get; set; }
        public string GiverName { get; set; }
    }
}