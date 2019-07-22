using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Zeus.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {

            if (context.Database.GetMigrations().Count() > 0
                    && context.Database.GetPendingMigrations().Count() == 0
                    && context.Products.Count() == 0)
            {

                context.Products.AddRange(
                    new Product
                    {
                        Name = "SUGAR FREE NATURA DIET SUGAR 80G",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 200,
                        ReOrder = 300,
                        Price = 250,
                        ImageUrl = "https://i.imgur.com/yTJiFD4.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA SWEET 200 DROPS 10ML",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 550,
                        ReOrder = 200,
                        Price = 150,
                        ImageUrl = "https://i.imgur.com/q63En5T.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA 100 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 450,
                        ReOrder = 300,
                        Price = 60,
                        ImageUrl = "https://i.imgur.com/NAzqfF8.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA 200 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 400,
                        ReOrder = 250,
                        Price = 130,
                        ImageUrl = "https://i.imgur.com/KupHlpz.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD 100 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 100,
                        ReOrder = 300,
                        Price = 60,
                        ImageUrl = "https://i.imgur.com/W4oLpLL.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD 300 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 550,
                        ReOrder = 300,
                        Price = 160,
                        ImageUrl = "https://i.imgur.com/GpXvzK9.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD 500 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 800,
                        ReOrder = 250,
                        Price = 230,
                        ImageUrl = "https://i.imgur.com/bIYTbvm.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD PELLETS 25S SACHET",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 450,
                        ReOrder = 300,
                        Price = 50,
                        ImageUrl = "https://i.imgur.com/Gk2R242.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD PELLETS 50S SACHET",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 700,
                        ReOrder = 250,
                        Price = 70,
                        ImageUrl = "https://i.imgur.com/q3qj3RV.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD PELLETS 100S SACHET",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 1000,
                        ReOrder = 400,
                        Price = 150,
                        ImageUrl = "https://i.imgur.com/evAwSfG.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE GOLD POWER 100G",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 500,
                        ReOrder = 300,
                        Price = 150,
                        ImageUrl = "https://i.imgur.com/2IZEjf1.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA 300 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 740,
                        ReOrder = 300,
                        Price = 200,
                        ImageUrl = "https://i.imgur.com/dPEgBld.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA 500 PELLETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 700,
                        ReOrder = 250,
                        Price = 300,
                        ImageUrl = "https://i.imgur.com/Z5cxgoO.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA PELLETS 25S SACHETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 300,
                        ReOrder = 500,
                        Price = 50,
                        ImageUrl = "https://i.imgur.com/5HoDtZ0.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA PELLETS 50S SACHETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 970,
                        ReOrder = 400,
                        Price = 80,
                        ImageUrl = "https://i.imgur.com/2s46fOG.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA PELLETS 100S SACHETS",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 400,
                        ReOrder = 500,
                        Price = 150,
                        ImageUrl = "https://i.imgur.com/SIP08nR.jpg"
                    },
                    new Product
                    {
                        Name = "SUGAR FREE NATURA POWDER 100G",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Quantity = 290,
                        ReOrder = 300,
                        Price = 150,
                        ImageUrl = "https://i.imgur.com/i0Ufv2u.jpg"
                    });
                context.SaveChanges();
            }
        }
    }
}