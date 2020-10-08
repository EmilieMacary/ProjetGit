using DecouverteEntityFrameworkCodeFirst;
using DecouverteEntityFrameworkQuery;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteAspNetCore.Controllers
{
    public class ItemController : Controller
    {
        private MyDbContext MyDbContext;
        public static Query Query;

        public ItemController(MyDbContext context)
        {
            MyDbContext = context;
        }
        public IActionResult Index()
        {
            Query = new Query(MyDbContext);
            var listItems = Query.ItemsFromStore();
            MonSuperViewModel monSuperViewModel = new MonSuperViewModel { ListItem = listItems };
            return View(monSuperViewModel);
        }
    }
}
