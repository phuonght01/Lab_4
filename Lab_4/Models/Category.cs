using System;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.Models
{
    public class Category : DbContext
    {
        // Your context has been configured to use a 'Category' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.Models.Category' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Category' 
        // connection string in the application configuration file.
        public Category()
            : base("name=Category")
        {
        }

        public byte Id { get; set; }

        public string name { get; set; }

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