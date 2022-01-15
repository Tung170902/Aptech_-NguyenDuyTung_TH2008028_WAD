using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace wad.Models
{
    public class datacontext:DbContext
    {
        public datacontext() : base("Wad1") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
    }
}