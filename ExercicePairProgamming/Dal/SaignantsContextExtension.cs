using ExercicePairProgamming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Dal
{
    public static class SaignantsContextExtension
    {
        public static void Initialize(this SaignantsContext context, bool dropAlways = false)
        {
            if (dropAlways)
                context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            if (context.Menus.Any())
                return;

            #region Beverages
            var beverages = new List<Beverage>()
            {
                new Beverage
                {
                    Name = "Coca zero",
                    Price = 5,
                    Stockpiled = 25,
                    Millimeter = 75,
                    IsCarbonated = true
                },
                new Beverage
                {
                    Name = "Orangina",
                    Price = 4,
                    Stockpiled = 20,
                    Millimeter = 50,
                    IsCarbonated = true
                },
            };
            context.Beverages.AddRange(beverages);
            #endregion

            #region Sides
            var sides = new List<Side>()
            {
                new Side()
                {
                    Name = "Frites",
                    Price = 3,
                    Stockpiled = 150,
                    Weight = 30,
                    SaltWeight = 10
                },
                new Side()
                {
                    Name = "Salade",
                    Price = 2,
                    Stockpiled = 85,
                    Weight = 15,
                    SaltWeight = 0
                }
            };

            context.Sides.AddRange(sides);
            #endregion

            #region Desserts
            var desserts = new List<Dessert>()
            {
                new Dessert()
                {
                    Name = "Mousse au chocolat",
                    Price = 5,
                    Stockpiled = 45,
                    Millimeter = 20,
                    IsFrozen = true
                },
                new Dessert()
                {
                    Name = "Crème brulée",
                    Price = 4,
                    Stockpiled = 36,
                    Millimeter = 15,
                    IsFrozen = true
                }
            };
            context.Desserts.AddRange(desserts);
            #endregion

            #region Burgers
            var burgers = new List<Burger>()
            {
                new Burger()
                {
                    Name = "Classic",
                    Price = 7,
                    Stockpiled = 68,
                    Weight = 100,
                    BeefWeight = 60
                },
                new Burger()
                {
                    Name = "Extra",
                    Price = 9,
                    Stockpiled = 51,
                    Weight = 120,
                    BeefWeight = 65
                }
            };
            context.Burgers.AddRange(burgers);
            #endregion

            #region Menus
            var menus = new List<Menu>()
            {
                new Menu()
                {
                    Name = "Classic beef",
                    Price = 11,
                    Beverage = beverages[0],
                    Side = sides[0],
                    Dessert = desserts[1],
                    Burger = burgers[0]
                },
                new Menu()
                {
                    Name = "Cheese bacon Supra",
                    Price = 13,
                    Beverage = beverages[1],
                    Side = sides[0],
                    Dessert = desserts[0],
                    Burger = burgers[1]
                }
            };
            context.Menus.AddRange(menus);
            #endregion

            context.SaveChanges();
        }
    }
}
