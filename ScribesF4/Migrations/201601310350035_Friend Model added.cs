namespace ScribesF4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FriendModeladded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Individual_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Individual_Id)
                .Index(t => t.Individual_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friends", "Individual_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Friends", new[] { "Individual_Id" });
            DropTable("dbo.Friends");
        }
    }
}
