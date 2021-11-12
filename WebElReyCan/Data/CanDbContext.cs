using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class CanDbContext : DbContext
    {
        public CanDbContext() : base("KeyDB") { }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}