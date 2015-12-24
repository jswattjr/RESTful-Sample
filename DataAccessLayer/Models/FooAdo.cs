namespace DataAccessLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FooAdo : DbContext
    {
        // Your context has been configured to use a 'FooAdo' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataAccessLayer.Models.FooAdo' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FooAdo' 
        // connection string in the application configuration file.
        public FooAdo()
            : base("name=FooAdo")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Foo> FooEntities { get; set; }
    }

}