using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstExample
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ExampleDbContext>
    {
        ExampleDbContext IDesignTimeDbContextFactory<ExampleDbContext>.CreateDbContext(string[] args)
        {
            //var ConnectionString = @"Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;";
            var ConnectionString = @"Server=localhost\SQLEXPRESS;Database=DbExample;Trusted_Connection=True;";
            DbContextOptionsBuilder<ExampleDbContext> optionBuilder = new DbContextOptionsBuilder<ExampleDbContext>();
            optionBuilder.UseSqlServer(ConnectionString);
            return new ExampleDbContext(optionBuilder.Options);
        }
    }
}
