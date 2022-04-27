namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _UserTableArrangement : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.dbUsers", "soyAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.dbUsers", "soyAd", c => c.String());
        }
    }
}
