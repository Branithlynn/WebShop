using Microsoft.AspNetCore.Mvc;
using WebShop.Context;
using WebShop.Repository;

namespace WebShop.Controllers
{
    public class AdminViewController : Controller
    {
        public IActionResult Index()
        {
            ConnectionContext context = new ConnectionContext();
            return View(context.Users);
        }
        public IActionResult Delete(int Id)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.Delete(id);

        }
    }
}
