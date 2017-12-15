using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewbridgeLibrary.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}