using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineMovieSystem.Models
{
    // 数据库上下文
    public class MovieDB : DbContext
    {
        public MovieDB() : base("MovieDBConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieCategory> MovieCategories { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }

        public DbSet<MovieComment> MovieComments { get; set; }

    }
}