using UserApi.Models;
namespace UserApi.Repository

{
    public interface IUserRepo
    {
        void Register(User user);
         User Validate(string UserName, string Password); 
        void Update(User user);
    }
}
