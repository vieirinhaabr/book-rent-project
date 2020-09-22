namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBookNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Title", c => c.String());
            AddColumn("dbo.Books", "Author", c => c.String());
            DropColumn("dbo.Books", "BookName");
            DropColumn("dbo.Books", "BookAuthor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "BookAuthor", c => c.String());
            AddColumn("dbo.Books", "BookName", c => c.String());
            DropColumn("dbo.Books", "Author");
            DropColumn("dbo.Books", "Title");
        }
    }
}
