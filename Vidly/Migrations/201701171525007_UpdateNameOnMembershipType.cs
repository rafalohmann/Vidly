namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameOnMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.MembershipTypes DROP CONSTRAINT DF__Membership__Name__398D8EEE");
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.Byte(nullable: false));
        }
    }
}
