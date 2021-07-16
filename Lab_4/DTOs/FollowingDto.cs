using System;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.DTOs
{
    public class FollowingDto : DbContext
    {
        // Your context has been configured to use a 'FollowingDto' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.DTOs.FollowingDto' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FollowingDto' 
        // connection string in the application configuration file.
        public FollowingDto()
            : base("name=FollowingDto")
        {
        }

        public string FolloweeId { get; set; }
        public string FollowerId { get; set; }

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