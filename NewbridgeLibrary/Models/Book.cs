using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NewbridgeLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public int? AuthorId { get; set; }
        
        public virtual Author Author { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }

    }
}