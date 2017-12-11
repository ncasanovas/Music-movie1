namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Description", c => c.String());
            AddColumn("dbo.Songs", "Artist", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Artist");
            DropColumn("dbo.Movies", "Description");
        }
    }
}
