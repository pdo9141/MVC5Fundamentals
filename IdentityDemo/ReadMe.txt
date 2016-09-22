01) Added Movie class and FavoriteBook property to Models/IdentityModels
02) Go to PMC and type enable-migrations
03) Set AutomaticMigrationsEnabled to true in Migrations/Configuration class to avoid Add-Migration command
04) Update Seed method of Migrations/Configuration class
05) Go to PMC and type update-database
06) Go to App_Start/Startup.Auth to enable third party login (Facebook, Google, etc)
07) To get login info from external partners, leverage the AuthenticationManager.AuthenticateAsync (see AccountController/ExternalLoginCallback),
    different partners will give different claims info (email, username, etc.)