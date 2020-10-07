using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstExample
{
    public class DBConnection : IDesignTimeDbContextFactory<MyDbContext>
    {
        MyDbContext IDesignTimeDbContextFactory<MyDbContext>.CreateDbContext(string[] args)
        {
            var ConnectionString = @"Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;";
            DbContextOptionsBuilder<MyDbContext> optionBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionBuilder.UseSqlServer(ConnectionString);
            throw new NotImplementedException();
        }
    }
}
