namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentStartAndFinish : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.dbContents", "ContentStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.dbContents", "ContentFinishDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.dbContents", "ContentFinishDate");
            DropColumn("dbo.dbContents", "ContentStartDate");
        }
    }
}
