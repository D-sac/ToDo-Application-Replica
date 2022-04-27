namespace Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_Databse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dbCategories",
                c => new
                    {
                        cID = c.Int(nullable: false, identity: true),
                        cName = c.String(),
                        description = c.String(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.cID)
                .ForeignKey("dbo.dbUsers", t => t.User_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.dbUsers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ad = c.String(),
                        soyAd = c.String(),
                        yas = c.Int(nullable: false),
                        mail = c.String(),
                        sifre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.dbContents",
                c => new
                    {
                        conID = c.Int(nullable: false, identity: true),
                        conName = c.String(),
                        con_tent = c.String(),
                        conYear = c.DateTime(nullable: false),
                        dbCategory_cID = c.Int(),
                    })
                .PrimaryKey(t => t.conID)
                .ForeignKey("dbo.dbCategories", t => t.dbCategory_cID)
                .Index(t => t.dbCategory_cID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.dbContents", "dbCategory_cID", "dbo.dbCategories");
            DropForeignKey("dbo.dbCategories", "User_id", "dbo.dbUsers");
            DropIndex("dbo.dbContents", new[] { "dbCategory_cID" });
            DropIndex("dbo.dbCategories", new[] { "User_id" });
            DropTable("dbo.dbContents");
            DropTable("dbo.dbUsers");
            DropTable("dbo.dbCategories");
        }
    }
}
