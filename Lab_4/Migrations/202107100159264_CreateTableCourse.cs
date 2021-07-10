namespace Lab_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(),
                        Place = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        Lecture_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Lecture_Id)
                .Index(t => t.Lecture_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Lecture_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lecture_Id" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
