namespace ScribesF4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedjointable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StoryApplicationUsers", "Story_Id", "dbo.Stories");
            DropForeignKey("dbo.StoryApplicationUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.StoryApplicationUsers", new[] { "Story_Id" });
            DropIndex("dbo.StoryApplicationUsers", new[] { "ApplicationUser_Id" });
            DropTable("dbo.StoryApplicationUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StoryApplicationUsers",
                c => new
                    {
                        Story_Id = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Story_Id, t.ApplicationUser_Id });
            
            CreateIndex("dbo.StoryApplicationUsers", "ApplicationUser_Id");
            CreateIndex("dbo.StoryApplicationUsers", "Story_Id");
            AddForeignKey("dbo.StoryApplicationUsers", "ApplicationUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StoryApplicationUsers", "Story_Id", "dbo.Stories", "Id", cascadeDelete: true);
        }
    }
}
