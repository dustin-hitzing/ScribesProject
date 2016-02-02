namespace ScribesF4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetest2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUserStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        ThisStory_Id = c.Int(),
                        Writer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stories", t => t.ThisStory_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Writer_Id)
                .Index(t => t.ThisStory_Id)
                .Index(t => t.Writer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserStories", "Writer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUserStories", "ThisStory_Id", "dbo.Stories");
            DropIndex("dbo.ApplicationUserStories", new[] { "Writer_Id" });
            DropIndex("dbo.ApplicationUserStories", new[] { "ThisStory_Id" });
            DropTable("dbo.ApplicationUserStories");
        }
    }
}
