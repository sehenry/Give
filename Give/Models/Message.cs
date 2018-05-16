using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Give.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }
        public string ReceivedMessage { get; set; }
        public string SentMessage { get; set; }
        public DateTime DateTime { get; set; }
    }
}