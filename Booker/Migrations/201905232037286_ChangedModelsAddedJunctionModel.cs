namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModelsAddedJunctionModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropColumn("dbo.Customers", "BooksRenting");
            DropColumn("dbo.Books", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            AddColumn("dbo.Customers", "BooksRenting", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "Customer_Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
