using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecouverteEntityFrameworkCodeFirst;
using DecouverteEntityFrameworkQuery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DecouverteAspNetCore.Controllers
{
    public class ItemController : Controller
    {
        private MyDbContext MyDbContext;
        public static Query Query;
        public IActionResult Index()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(@"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=DecouverteEntityFrameworkCodeFirst;Trusted_Connection=True;");
            MyDbContext = new MyDbContext(optionsBuilder.Options);
            Query = new Query(MyDbContext);

            var listItems = Query.ItemsFormStore();

            MonSuperViewModel monSuperViewModel = new MonSuperViewModel { ListItem = listItems };

            return View(monSuperViewModel);
        }
    }
}
