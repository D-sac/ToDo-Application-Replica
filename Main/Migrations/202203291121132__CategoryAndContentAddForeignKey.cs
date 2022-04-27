namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _CategoryAndContentAddForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.dbCategories", "User_id", "dbo.dbUsers");
            DropForeignKey("dbo.dbContents", "dbCategory_cID", "dbo.dbCategories");
            DropIndex("dbo.dbCategories", new[] { "User_id" });
            DropIndex("dbo.dbContents", new[] { "dbCategory_cID" });
            RenameColumn(table: "dbo.dbCategories", name: "User_id", newName: "UserID");
            RenameColumn(table: "dbo.dbContents", name: "dbCategory_cID", newName: "CategoryID");
            AlterColumn("dbo.dbCategories", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.dbContents", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.dbCategories", "UserID");
            CreateIndex("dbo.dbContents", "CategoryID");
            AddForeignKey("dbo.dbCategories", "UserID", "dbo.dbUsers", "id", cascadeDelete: true);
            AddForeignKey("dbo.dbContents", "CategoryID", "dbo.dbCategories", "cID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.dbContents", "CategoryID", "dbo.dbCategories");
            DropForeignKey("dbo.dbCategories", "UserID", "dbo.dbUsers");
            DropIndex("dbo.dbContents", new[] { "CategoryID" });
            DropIndex("dbo.dbCategories", new[] { "UserID" });
            AlterColumn("dbo.dbContents", "CategoryID", c => c.Int());
            AlterColumn("dbo.dbCategories", "UserID", c => c.Int());
            RenameColumn(table: "dbo.dbContents", name: "CategoryID", newName: "dbCategory_cID");
            RenameColumn(table: "dbo.dbCategories", name: "UserID", newName: "User_id");
            CreateIndex("dbo.dbContents", "dbCategory_cID");
            CreateIndex("dbo.dbCategories", "User_id");
            AddForeignKey("dbo.dbContents", "dbCategory_cID", "dbo.dbCategories", "cID");
            AddForeignKey("dbo.dbCategories", "User_id", "dbo.dbUsers", "id");
        }
    }
}
