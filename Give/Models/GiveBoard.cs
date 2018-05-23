using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Give.Models
{
    public class GiveBoard
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string GiverName { get; set; }
    }
}