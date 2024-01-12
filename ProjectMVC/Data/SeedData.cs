using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectMVC.Data;
using ProjectMVC.Models;
using System;
using System.Linq;

namespace ProjectMVC.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjectMVCContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }
                context.Products.AddRange(
                    new Products
                    {
                        Name = "Products 1",
                        Description = "This is product1",
                        Image = "asdfghjk",
                        Quantity = 222,
                        Price = 7.99M
                    },
                    new Products
                    {
                        Name = "Products 2",
                        Image = "asdfghjk",
                        Description = "This is product 2",
                        Quantity = 522,
                        Price = 1.99M
                    },
                     new Products
                     {
                         Name = "Products 3",
                         Description = "This is product1",
                         Quantity = 222,
                         Image = "asdfghjk",
                         Price = 7.99M
                     },
                      new Products
                      {
                          Name = "Products 4",
                          Description = "This is product1",
                        Image = "asdfghjk",
                          Quantity = 222,
                          Price = 7.99M
                      }
                );
                context.SaveChanges();
            }
        }
    }
}
