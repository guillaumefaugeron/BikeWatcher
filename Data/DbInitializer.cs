using BikeWatcher.Models;
using System;
using System.Linq;
using BikeWatcher.Data;

namespace BikeWatcher.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FavorisContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Favoris.Any())
            {
                return;   // DB has been seeded
            }

            var favories = new Favoris[]
            {
            new Favoris{IDStation=16005},
            new Favoris{IDStation=16045}

            };
            foreach (Favoris f  in favories)
            {
                context.Favoris.Add(f);
            }
            context.SaveChanges();

           
        }
    }
}