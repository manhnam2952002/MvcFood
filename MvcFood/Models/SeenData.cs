using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFood.Models
{
    public class SeenData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFoodContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFoodContext>>()))
            {
                // Look for any movies.
                if (context.Food.Any())
                {
                    return;   // DB has been seeded
                }

                context.Food.AddRange(
                    new Food
                    {
                        Title = "Món ăn đường phố",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Bánh mì",
                        Price = 7.99M
                    },

                    new Food
                    {
                        Title = "Món ăn sang chảnh ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Tôm hùm",
                        Price = 8.99M
                    },

                    new Food
                    {
                        Title = "Món ăn thú vị",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Trứng vịt lộn",
                        Price = 9.99M
                    },

                    new Food
                    {
                        Title = "Món ăn truyền thống",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Phở",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
