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




            context.Database.EnsureCreated();

            // Look for any students.
            if (context.SignVelo.Any())
            {
                return;   // DB has been seeded
            }

            var signVelos = new SignVelo[]
            {
                new SignVelo{IdVVelo = 125,Commentaire = "ca marche0",Email = "gui@36.com"},

            };
            foreach (SignVelo f in signVelos)
            {
                context.SignVelo.Add(f);
            }
            context.SaveChanges();


        }


    }
}