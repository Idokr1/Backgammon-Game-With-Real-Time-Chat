using DAL.Models;

namespace Logic.Interfaces
{
    public interface IChatService
    {
        void CreateChat(Chat chat);
        Chat GetChat(string sender, string reciver);
        void SendMessage(Chat chat, Message message);
        void Update(Chat chat);
    }
}
