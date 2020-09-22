namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJunctionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerBooks");
        }
    }
}
