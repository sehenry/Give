using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Give.Models
{
    public class ItemRequest
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string UserName { get; set; }
        public string ItemRequestMessage { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}