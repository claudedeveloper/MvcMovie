namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Episode I: The Phantom Menace",
                    ReleaseDate = DateTime.Parse("1999-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Episode II: Attack of the Clones",
                     ReleaseDate = DateTime.Parse("2002-3-13"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Episode III: Revenge of the Sith",
                     ReleaseDate = DateTime.Parse("2005-2-23"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 9.99M
                 },

                new Movie
                {
                    Title = "Episode IV: A New Hope",
                    ReleaseDate = DateTime.Parse("1977-4-15"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 5.99M
                },

                  new Movie
               {
                   Title = "Episode V: The Empire Strikes Back",
                   ReleaseDate = DateTime.Parse("1980-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               },

                  new Movie
               {
                   Title = "Episode VI: Return of the Jedi",
                   ReleaseDate = DateTime.Parse("1983-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 13.99M
               },

                  new Movie
               {
                   Title = "Episode VII: The Force Awakens",
                   ReleaseDate = DateTime.Parse("2015-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               }

            );
        }
    }
}
