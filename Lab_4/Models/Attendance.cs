using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.Models
{
    public class Attendance : DbContext
    {
        // Your context has been configured to use a 'Attendance' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.Models.Attendance' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Attendance' 
        // connection string in the application configuration file.
        public Attendance()
            : base("name=Attendance")
        {
        }

        public Course Course { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Courseid { get; set; }

        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}