using Models.Models;

namespace DAL.Interfaces
{
    public interface IChatRepository
    {
        void Add(Chat chat);
        void Remove(Chat chat);
        Chat Get(Chat chat);
        List<Chat> GetAll();
        void Update(Chat chat);
    }
}
