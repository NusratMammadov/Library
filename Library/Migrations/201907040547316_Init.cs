namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomrId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Count = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Books_Id = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Books_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Books_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.OrderItems", "Books_Id", "dbo.Books");
            DropIndex("dbo.OrderItems", new[] { "Customer_Id" });
            DropIndex("dbo.OrderItems", new[] { "Books_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Books");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Customers");
        }
    }
}
