using APIday2.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace APIday2
{
    public class ApiContext : DbContext
    {
        // Your context has been configured to use a 'ApiContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'APIday2.ApiContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApiContext' 
        // connection string in the application configuration file.
        public ApiContext()
            : base("name=ApiContext")
        {
        }
        public virtual DbSet<Student> Students { set; get; }
        public virtual DbSet<Department> Departments { set; get; }

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