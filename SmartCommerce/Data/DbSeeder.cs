using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartCommerce.Constants;
using SmartCommerce.Models; // Make sure Role and Book models are available

namespace SmartCommerce.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            try
            {
                var context = service.GetService<ApplicationDbContext>();

                // Apply any pending migrations
                if ((await context.Database.GetPendingMigrationsAsync()).Count() > 0)
                {
                    await context.Database.MigrateAsync();
                }

                // Seed custom roles (Customer, Seller, Admin)
                await SeedRolesAsync(context);

                // Seed admin user using ASP.NET Identity (optional, depending on what you want)
                var userMgr = service.GetService<UserManager<IdentityUser>>();

                var admin = new IdentityUser
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true
                };

                var userInDb = await userMgr.FindByEmailAsync(admin.Email);
                if (userInDb is null)
                {
                    await userMgr.CreateAsync(admin, "Admin@123");
                    // Optional: if still using IdentityRole too
                    // await userMgr.AddToRoleAsync(admin, "Admin");
                }

                // Seed genres and books
                if (!context.Genres.Any())
                {
                    await SeedGenreAsync(context);
                }

                if (!context.Books.Any())
                {
                    await SeedBooksAsync(context);

                    // Update stock table
                    await context.Database.ExecuteSqlRawAsync(@"
                        INSERT INTO Stock(BookId, Quantity) 
                        SELECT b.Id, 10 
                        FROM Book b
                        WHERE NOT EXISTS (
                            SELECT * FROM [Stock]
                        );
                    ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region Private Seeder Methods

        private static async Task SeedRolesAsync(ApplicationDbContext context)
        {
            if (!context.AppRoles.Any())
            {
                context.AppRoles.AddRange(
                    new AppRole { RoleName = "Customer" },
                    new AppRole { RoleName = "Seller" },
                    new AppRole { RoleName = "Admin" }
                );
                await context.SaveChangesAsync();
            }
        }


        private static async Task SeedGenreAsync(ApplicationDbContext context)
        {
            var genres = new[]
            {
                new Genre { GenreName = "Romance" },
                new Genre { GenreName = "Action" },
                new Genre { GenreName = "Thriller" },
                new Genre { GenreName = "Crime" },
                new Genre { GenreName = "SelfHelp" },
                new Genre { GenreName = "Programming" }
            };

            await context.Genres.AddRangeAsync(genres);
            await context.SaveChangesAsync();
        }

        private static async Task SeedBooksAsync(ApplicationDbContext context)
        {
            var books = new List<Book>
            {
                new Book { BookName = "Pride and Prejudice", AuthorName = "Jane Austen", Price = 12.99M,  GenreId = 1 },
                new Book { BookName = "The Notebook", AuthorName = "Nicholas Sparks", Price = 11.99M, GenreId = 1 },
                // ... (other books unchanged)
                new Book { BookName = "Head First Design Patterns", AuthorName = "Eric Freeman", Price = 20.99M, GenreId = 6 }
            };

            await context.Books.AddRangeAsync(books);
            await context.SaveChangesAsync();
        }

        #endregion
    }
}
