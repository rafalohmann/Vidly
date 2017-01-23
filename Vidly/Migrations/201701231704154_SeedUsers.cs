namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'023a7a29-dbc2-4a08-9c02-aaacaffee579', N'admin@vidly.com', 0, N'ANVEsDND877ughpgUTEGcsCdLFDW0+EfTnXlmXAHL2XW2/JOdl+qgAtPu3O+5rco5w==', N'd659826c-2386-4183-a886-95e8afd1440a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'edc12719-1e77-4690-951b-da1b7fc964b8', N'guest@vidly.com', 0, N'ACXxBnpZsa9xVlca6TzhvohVmU3pMOWCT2yFU3yOLmrPMXNz4H6BOFYsteQi0Bk81A==', N'52758594-a20a-4b5b-be52-2b70b674606d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fd6e1f88-b2dc-44ee-ad18-1cf407ccc3bf', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'023a7a29-dbc2-4a08-9c02-aaacaffee579', N'fd6e1f88-b2dc-44ee-ad18-1cf407ccc3bf')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
