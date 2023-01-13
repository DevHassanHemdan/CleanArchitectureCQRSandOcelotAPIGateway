using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Presistance
{
    public class DbInitializer
    {
        public static async Task SeedData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                DataContext context = serviceScope.ServiceProvider.GetService<DataContext>();
                UserManager<Users> userManager = serviceScope.ServiceProvider.GetService<UserManager<Users>>();

                if (!await userManager.Users.AnyAsync())
                {
                    List<Users> users = new List<Users>()
                    {
                        new Users()
                        {
                            Id = Guid.NewGuid().ToString(),
                            FirstName= "Hassan",
                            LastName ="Hemdan",
                            Email="hassanhemdan92@gmail.com",
                            UserName = "Hassan Hemdan",
                            Address = "Cairo, Egypt",
                            NormalizedUserName = "Hassan Hemdan",
                            NormalizedEmail= "hassanhemdan92@gmail.com"
                        }
                    };
                    foreach (Users user in users)
                    {
                        await userManager.AddPasswordAsync(user, "P@ssw0rd");
                        await context.Users.AddAsync(user);
                    }
                }

                if (!context.Categories.Any())
                {
                    List<Categories> categories = new List<Categories>()
                        {
                            new Categories()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Mobiles",
                                CreatedOn = DateTime.Now
                            }, new Categories()
                            {
                                 Id = Guid.NewGuid(),
                                Name = "Tvs",
                                CreatedOn = DateTime.Now
                            }, new Categories()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Watches",
                                CreatedOn = DateTime.Now
                            }

                        };
                    await context.Categories.AddRangeAsync(categories);
                }

                
                await context.SaveChangesAsync();
            }
        }
    }
}

