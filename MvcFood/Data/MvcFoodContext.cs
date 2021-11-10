using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFood.Models;

namespace MvcFood.Data
{
    public class MvcFoodContext : DbContext
    {
        public MvcFoodContext (DbContextOptions<MvcFoodContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFood.Models.Food> Food { get; set; }
    }
}
