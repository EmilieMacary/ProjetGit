using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DecouverteEntityFrameworkCodeFirst
{
    public class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            string connectionString = @"Server=.\sqlexpress;Database=DecouverteEntityFrameworkCodeFirst;Trusted_Connection=True;";
            //string connectionString = @"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;";
            DbContextOptionsBuilder<MyDbContext> optionBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MyDbContext(optionBuilder.Options);
        }
    }
}