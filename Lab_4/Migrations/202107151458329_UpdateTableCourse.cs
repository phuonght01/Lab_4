namespace Lab_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Courses", "CategoryId");
            AddForeignKey("dbo.Courses", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId" });
        }
    }
}
