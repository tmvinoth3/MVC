using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace odetofood.Models
{
    public class FoodDBsql : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}