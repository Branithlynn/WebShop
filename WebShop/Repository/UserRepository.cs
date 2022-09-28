using WebShop.Context;
using WebShop.Entity;
using WebShop.Context;
namespace WebShop.Repository
{
    public class UserRepository
    {
        public ConnectionContext DbCont = new ConnectionContext();
        public User GetByUserNameAndPassword(string Username, string Password)
        {
            foreach(User item in DbCont.Users)
            {
                if(item.Username==Username&&
                    item.Password == Password)
                {
                    return item;
                }
            }
            return null;
        }
        public void Register(string Name,string Username, string Password, bool isAdmin)
        {
            ConnectionContext context = new ConnectionContext();
            User user = new User();
            user.Name = Name;
            user.Password = Password;
            user.Username = Username;
            user.isAdmin = isAdmin;
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
