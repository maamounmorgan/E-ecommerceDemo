using ecommerceDemo.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceDemo.Models
{
    public class ecommerceDbContext : DbContext
    {
        public ecommerceDbContext(DbContextOptions<ecommerceDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
