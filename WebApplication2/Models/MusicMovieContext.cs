using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MusicMovieContext : DbContext
    {

        public MusicMovieContext():
            base("MusicMovieContext")
        {

        }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}