using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways
{
    public class MessageGateway : IMessageGateway
    {
        public IEnumerable<Message> GetMessages()
        {
            return new Message[]
            {
                new("Hello World!", "What a wonderful World!", "Luca", DateTime.Now, DateTime.Now, 1)
            };
        }

        public Message GetMessage(int id)
        {
            return GetMessages().Single(t => t.Id == id);
        }
    }
}