using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.Models
{
    public class Following : DbContext
    {
        // Your context has been configured to use a 'Following' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.Models.Following' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Following' 
        // connection string in the application configuration file.
        public Following()
            : base("name=Following")
        {
        }

        public ApplicationUser Follower { get; set; }

        public ApplicationUser Followee { get; set; }

        [Key]
        [Column(Order = 1)]
        public string FollowerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FolloweeId { get; set; }


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