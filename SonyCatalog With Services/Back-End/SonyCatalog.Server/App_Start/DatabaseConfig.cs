using SonyCatalog.Data;
using SonyCatalog.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SonyCatalog.Server.App_Start
{
    public static  class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SonyCatalogDbContext, Configuration>());
            SonyCatalogDbContext.Create().Database.Initialize(true);
        }
    }
}