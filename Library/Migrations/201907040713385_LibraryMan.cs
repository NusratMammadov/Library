namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryMan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "PhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.OrderItems", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Count", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Books", "Count", c => c.String());
            AlterColumn("dbo.Books", "Name", c => c.String());
            AlterColumn("dbo.OrderItems", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNo", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
