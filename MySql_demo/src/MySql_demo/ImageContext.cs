using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MySql_demo
{
    public class ImageContext:DbContext
    {
        public ImageContext(DbContextOptions<ImageContext> option):base(option)
        {

        }
    }

    public static class ImageContextFactory
    {
        public static ImageContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ImageContext>();
            optionsBuilder.UseMySql(connectionString);

            //Ensure database creation
            var context = new ImageContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }

    public class ImageTb
    {
        public ImageTb()
        {
        }

        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

