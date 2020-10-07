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

        public ItemController(MyDbContext context)
        {
            MyDbContext = context;
        }
        public IActionResult Index()
        {
            Query = new Query(MyDbContext);
            var listItems = Query.ItemsFormStore();
            MonSuperViewModel monSuperViewModel = new MonSuperViewModel { ListItem = listItems };
            return View(monSuperViewModel);
        }
    }
}
