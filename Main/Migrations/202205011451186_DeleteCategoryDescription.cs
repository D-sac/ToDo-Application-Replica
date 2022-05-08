namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryDescription : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.dbCategories", "description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.dbCategories", "description", c => c.String());
        }
    }
}
