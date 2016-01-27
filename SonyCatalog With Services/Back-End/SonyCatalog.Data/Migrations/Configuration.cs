namespace SonyCatalog.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SonyCatalog.Data.SonyCatalogDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SonyCatalog.Data.SonyCatalogDbContext";
        }

        protected override void Seed(SonyCatalog.Data.SonyCatalogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ProductCategories.AddOrUpdate(
                new ProductCategory() { CategoryName = "Consoles" },
                new ProductCategory() { CategoryName = "Phones" },
                new ProductCategory() { CategoryName = "Tvs" }
                );

            context.SaveChanges();

            var consoleCategory = context.ProductCategories.Where(cat => cat.CategoryName == "Consoles").FirstOrDefault();
            var phoneCategory = context.ProductCategories.Where(cat => cat.CategoryName == "Phones").FirstOrDefault();
            var tvCategory = context.ProductCategories.Where(cat => cat.CategoryName == "Tvs").FirstOrDefault();

            context.Consoles.AddOrUpdate(
                new GameConsole() { BundleName = "PlayStation 4 with Destiny + Vanguard and Watch_Dogs Special Edition", Url = "resources/console_resources/135137_gen_c.png", Price = 500.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with Call of Duty: Advanced Warfare Day Zero and The Last of Us Remastered", Url = "resources/console_resources/135138_gen_c.png", Price = 600.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with CoD: Advanced Warfare Day Zero, The Last of Us Remastered , Watch_Dogs and PS+ 12 Months", Url = "resources/console_resources/135139_gen_c.png", Price = 525.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with Destiny", Url = "resources/console_resources/300420_gen_c.png", Price = 450.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 black", Url = "resources/console_resources/300853_gen_c.png", Price = 400.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with Grand Theft Auto V and The Last of Us Remastered", Url = "resources/console_resources/302311_gen_c.png", Price = 520.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with DriveClub", Url = "resources/console_resources/302736_gen_c.png", Price = 450.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 with Far Cry 4", Url = "resources/console_resources/339657_gen_c.png", Price = 450.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "PlayStation 4 white", Url = "resources/console_resources/339661_gen_c.png", Price = 400.00, ProductCategory = consoleCategory },
                new GameConsole() { BundleName = "LittleBigPlanet 3 PlayStation 4 Console MEGA Pack - Only at GAME", Url = "resources/console_resources/342432_gen_c.png", Price = 430.00, ProductCategory = consoleCategory }
                );

            context.SaveChanges();

            context.Phones.AddOrUpdate(
                new Phone() { PhoneModel = "Sony Xperia C3", Price = 500, Url= "resources/phones_resources/sony-xperia-c3.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia E1", Price = 182, Url = "resources/phones_resources/sony-xperia-e1.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia E1 Dual", Price = 233, Url = "resources/phones_resources/sony-xperia-e1.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia E3", Price = 277, Url = "resources/phones_resources/sony-xperia-e3-dual.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia E3 Dual", Price = 310, Url = "resources/phones_resources/sony-xperia-e3-dual.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia M2", Price = 430, Url = "resources/phones_resources/sony-xperia-m2.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia M2 Dual", Price = 488, Url = "resources/phones_resources/sony-xperia-m2.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia Z1 Compact", Price = 400, Url = "resources/phones_resources/sony-xperia-z1-compact-new.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia Z1", Price = 400, Url = "resources/phones_resources/sony-xperia-z1-ofic.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia Z2a", Price = 550, Url = "resources/phones_resources/sony-xperia-z2a.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia Z3", Price = 700, Url = "resources/phones_resources/sony-xperia-z3-tablet-compact.jpg", ProductCategory = phoneCategory },
                new Phone() { PhoneModel = "Sony Xperia Z3", Price = 800, Url = "resources/phones_resources/sony-xperia-z3.jpg", ProductCategory = phoneCategory }
                );

            context.SaveChanges();

            context.Tvs.AddOrUpdate(
                new Tv() { TvModel = "84.6 (diag) X950B Flagship 4K Ultra HD TV", Url = "resources/tvs_resources/pSNYNA-XBR85X950B_main_v500.png", Price = 24999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "65 Class (diag) X950B Flagship 4K Ultra HD TV", Url = "resources/tvs_resources/pSNYNA-XBR85X950B_main_v500.png", Price = 6999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "78.6 (diag) X900B Premium 4K Ultra HD TV", Url = "resources/tvs_resources/pSNYNA-XBR79X900B_main_v500.png", Price = 7999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "64.5 (diag) X850B 4K Ultra HD TV", Url = "resources/tvs_resources/pSNYNA-XBR65X850B_main_v500.png", Price = 2499.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "64.5 (diag) W950B Ultimate LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL65W950B_main_v500.png", Price = 1999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "69.5 (diag) W850B Premium LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL70W850B_main_v500.png", Price = 2099.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "50 (diag) W800B Premium LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL50W800B_main_v500.png", Price = 999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "60 (diag) W630B LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL60W630B_main_v500.png", Price = 999.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "32 Class (31.5 diag) R420B Series LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL32R420B_main_v500.png", Price = 279.99, ProductCategory = tvCategory },
                new Tv() { TvModel = "60 (diag.) R510A Series LED HDTV", Url = "resources/tvs_resources/pSNYNA-KDL60R510A_main_v500.png", Price = 899.99, ProductCategory = tvCategory }

                );
            context.SaveChanges();
        }
    }
}
