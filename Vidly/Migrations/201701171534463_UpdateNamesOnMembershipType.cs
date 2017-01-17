namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNamesOnMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Trimesterly' where Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' where Id = 4");
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
