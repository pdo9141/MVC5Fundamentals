01) EF now supports multiple migrations
02) Go to PMC and type, enable-migrations -ContextTypeName ApplicationDbContext -MigrationsDirectory DataContexts\ApplicationMigrations
03) Go to PMC and type, enable-migrations -ContextTypeName BooksDb -MigrationsDirectory DataContexts\BooksMigrations
04) Go to PMC and type, add-migration -ConfigurationTypeName Books.Web.DataContexts.ApplicationMigrations.Configuration "InitialCreate"
05) Go to PMC and type, add-migration -ConfigurationTypeName Books.Web.DataContexts.BooksMigrations.Configuration "InitialCreate"
06) Go to PMC and type, update-database -ConfigurationTypeName Books.Web.DataContexts.ApplicationMigrations.Configuration
07) Go to PMC and type, update-database -ConfigurationTypeName Books.Web.DataContexts.BooksMigrations.Configuration
08) Add this snippet in DbContext class constructor, Database.Log = sql => Debug.Write(sql), to print SQL into Output (Debug) window
09) Install Glimpse MVC 5 and Glimpse EF6 to get insight on what EF is doing. Glimpse doesn't work well with async controller methods so turn
    off for now. Glimpse will not log until you go to localhost:xxxx/glimpse.axd and turn it on
10) To change DB owner schema to something other than dbo, go to your DbContext class and add override OnModelCreating, add modelBuilder.HasDefaultSchema("notdbo")