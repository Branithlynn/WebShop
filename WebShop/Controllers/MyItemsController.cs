using Microsoft.AspNetCore.Mvc;
using WebShop.Context;
using WebShop.Entity;
using WebShop.Services;

namespace WebShop.Controllers
{
    public class MyItemsController : Controller
    {
        public IActionResult Index()
        {
            ConnectionContext context = new ConnectionContext();
            List<MyItemEntity> myItemsEntities = new List<MyItemEntity>();
            foreach(MyItemEntity item in context.MyItemEntity)
            {
                if(item.Borrower == AuthenticationService.LoggedUser.Username||
                    item.Lender == AuthenticationService.LoggedUser.Username)
                {
                    myItemsEntities.Add(item);
                }
            }
            return View(myItemsEntities);
        }
    }
}
