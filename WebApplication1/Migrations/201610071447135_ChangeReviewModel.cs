namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReviewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Title", c => c.String());
            AddColumn("dbo.Reviews", "Content", c => c.String());
            DropColumn("dbo.Reviews", "Subject");
            DropColumn("dbo.Reviews", "ReviewSummary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "ReviewSummary", c => c.String());
            AddColumn("dbo.Reviews", "Subject", c => c.String());
            DropColumn("dbo.Reviews", "Content");
            DropColumn("dbo.Reviews", "Title");
        }
    }
}
