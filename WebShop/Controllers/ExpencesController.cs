
using Microsoft.AspNetCore.Mvc;
using WebShop.Context;
using WebShop.Entity;
using WebShop.Services;

namespace WebShop.Controllers
{
    public class ExpencesController : Controller
    {
        public IActionResult Index()
        {
            ConnectionContext context = new ConnectionContext();
            List<Expence> Expences = new List<Expence>();
            foreach (Expence item in context.Expences)
            {
                if (item.ParentId == AuthenticationService.LoggedUser.Id)
                {
                    Expences.Add(item);
                }
            }
            return View(Expences);
        }
    }
}
