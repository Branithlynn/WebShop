using WebShop.Entity;
using WebShop.Repository;

namespace WebShop.Services
{
    public class AuthenticationService
    {
        public static User LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            UserRepository usersRepo = new UserRepository();
            AuthenticationService.LoggedUser = usersRepo.GetByUserNameAndPassword(username, password);
        }
        public static void Logout()
        {
            AuthenticationService.LoggedUser = null;
        }
    }
}
