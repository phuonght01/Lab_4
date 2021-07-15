namespace Lab_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpCommingCourse : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COURSES (Lecture_Id, Place, DateTime, CategoryId) VALUES ('6cad02fc-8457-4f4a-a93b-72ccfd976181', convert(datetime,'18-09-21 10:34:09 PM',5), 1, 1)");
            Sql("INSERT INTO COURSES (Lecture_Id, Place, DateTime, CategoryId) VALUES ('6cad02fc-8457-4f4a-a93b-72ccfd976181', convert(datetime,'18-09-21 10:34:09 PM',5), 1, 2)");
            Sql("INSERT INTO COURSES (Lecture_Id, Place, DateTime, CategoryId) VALUES ('6cad02fc-8457-4f4a-a93b-72ccfd976181', convert(datetime,'18-09-21 10:34:09 PM',5), 1, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
