using Models.Models;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        void Add(User input);
        void Remove(string username);
        User Get(string username);
        List<User> GetAll();
        void Update(User input);
    }
}
