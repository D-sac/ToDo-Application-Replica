namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _dbUserAddUnique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.dbUsers", "ad", c => c.String(maxLength: 200));
            CreateIndex("dbo.dbUsers", "ad", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.dbUsers", new[] { "ad" });
            AlterColumn("dbo.dbUsers", "ad", c => c.String());
        }
    }
}
