using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewbridgeLibrary.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int? BookId { get; set; }
        public string Summary { get; set; }
        public int Rating { get; set; }
        public virtual Book Book { get; set; }

    }
}