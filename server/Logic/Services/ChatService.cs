using DAL.Interfaces;
using DAL.Models;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Services
{
    public class ChatService : IChatService
    {
        private IChatRepository repo;
        public ChatService(IChatRepository repo) => this.repo = repo;

        public void CreateChat(Chat chat) => repo.Add(chat);

        public Chat GetChat(string sender, string reciver)
        {
            var chat = repo.GetAll()
                            .FirstOrDefault(x =>
                            x.Users.Contains(sender)
                            && x.Users.Contains(reciver));

            if (chat == null)
            {
                chat = new Chat()
                {
                    Users = new string[] { sender, reciver },
                    Messages = new List<Message>()
                };
                CreateChat(chat);
            }

            return chat;
        }

        public void SendMessage(Chat chat, Message message)
        {
            repo.Get(chat)
                .Messages
                    .Add(message);
        }

        public void Update(Chat chat)
        {
            if (chat != default)
                repo.Update(chat);
        }
    }
}
