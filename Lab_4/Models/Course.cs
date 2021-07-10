using System;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.Models
{
    public class Course : DbContext
    {
        // Your context has been configured to use a 'Course' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.Models.Course' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Course' 
        // connection string in the application configuration file.
        public Course()
            : base("name=Course.cs")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }


        public int Id { get; set; }

        public ApplicationUser Lecture { get; set; }

        public string LecturerId { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public byte CategoryId { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}