using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewbridgeLibrary.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public int? BookId { get; set; }
        public int? AuthorId { get; set; }
        
        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}