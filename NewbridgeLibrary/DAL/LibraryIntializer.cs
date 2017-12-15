using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NewbridgeLibrary.Models;

namespace NewbridgeLibrary.DAL
{
    public class LibraryIntializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var books = new List<Book>
            {
            new Book{BookId='1',Title="Alexander",Genre="Romance", AuthorId='1'},
            new Book{BookId='2',Title="Alonso",Genre="Romance", AuthorId='1'},
            new Book{BookId='3',Title="Anand",Genre="Adventure", AuthorId='2'},
            new Book{BookId='4',Title="Barzdukas",Genre="Comedy", AuthorId='3'},
            new Book{BookId='5',Title="Li",Genre="Sci-fi", AuthorId='4'}
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var authors = new List<Author>
            {
            new Author{AuthorId=1,Name="Alexander",Age=33},
            new Author{AuthorId=2,Name="Alonso",Age=54},
            new Author{AuthorId=3,Name="Anand",Age=34},
            new Author{AuthorId=4,Name="Barzdukas",Age=56},
            new Author{AuthorId=5,Name="Li",Age=34}
            };

            authors.ForEach(s => context.Authors.Add(s));
            context.SaveChanges();

            var feedbacks = new List<Feedback>
            {
            new Feedback{FeedbackId='1',Summary="Alexander",Rating='2', BookId='1'},
            new Feedback{FeedbackId='2',Summary="Alonso",Rating='3', BookId='2' },
            new Feedback{FeedbackId='3',Summary="Anand",Rating='4', BookId='3'},
            new Feedback{FeedbackId='4',Summary="Barzdukas",Rating='5', BookId='4'},
            new Feedback{FeedbackId='5',Summary="Li",Rating='2', BookId='5'}
            };

            feedbacks.ForEach(s => context.Feedbacks.Add(s));
            context.SaveChanges();

            var collections = new List<Collection>
            {
            new Collection{BookId=1,AuthorId=1050},
            new Collection{BookId=1,AuthorId=4022},
            new Collection{BookId=1,AuthorId=4041},
            new Collection{BookId=2,AuthorId=1045},
            new Collection{BookId=2,AuthorId=3141},
            new Collection{BookId=2,AuthorId=2021},
            new Collection{BookId=3,AuthorId=1050}
            };
            collections.ForEach(s => context.Collections.Add(s));
            context.SaveChanges();


        }
}
}