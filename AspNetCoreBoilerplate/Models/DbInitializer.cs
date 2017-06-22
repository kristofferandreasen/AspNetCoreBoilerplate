using System.Linq;

namespace AspNetCoreBoilerplate.Models
{
    public class DbInitializer
    {
        // This Seed method is called in the startup file to populate the database
        public static void Seed(AppDbContext context)
        {

            // Ensure the database has been created
            context.Database.EnsureCreated();

            // Only continue if the database is empty
            if (context.Items.Any())
            {
                return;     // DB has been seeded
            }

            // Create a new list with items
            var Items = new Item[]
            {
                new Item {ItemId = 1, Name = "Chair", Price = 20},
                new Item {ItemId = 2, Name = "Table", Price = 50},
                new Item {ItemId = 3, Name = "Fork", Price = 4},
                new Item {ItemId = 4, Name = "Knife", Price = 5},
                new Item {ItemId = 5, Name = "Table Cloth", Price = 10}
            };

            // Add the items to the DB
            foreach (Item s in Items)
            {
                context.Items.Add(s);
            }

            // Save the changes to the database
            context.SaveChanges();

        }
    }
}