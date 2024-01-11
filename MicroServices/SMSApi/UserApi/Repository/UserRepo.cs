using UserApi.Models;

namespace UserApi.Repository
{
    public class UserRepo : IUserRepo
    {
        List<User> users = new List<User>();
        public void Register(User usr)
        {
            users.Add(usr);
        }

        public void Update(User user)
        {
          foreach (var k in users)
            {
                if(k.Id == user.Id)
                {
                    k.UserName = user.UserName;
                    k.Password = user.Password;
                    k.Email = user.Email;
                    k.Phone = user.Phone;
                }
            }
        }

        public User Validate(string username, string password)
        {
            return users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
