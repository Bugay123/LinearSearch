using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Chat
    {
        private List<ChatMessage> messages = new List<ChatMessage>();

        public void AddMessage(string sender, string message)
        {
            messages.Add(new ChatMessage(sender, message));
        }

        public List<ChatMessage> SearchMessages(string keyword)
        {
            List<ChatMessage> result = new List<ChatMessage>();

            foreach (var message in messages)
            {
                if (message.Message.Contains(keyword))
                {
                    result.Add(message);
                }
            }

            return result;
        }

        public List<ChatMessage> LinearSearchMessages(string keyword)
        {
            List<ChatMessage> result = new List<ChatMessage>();

            foreach (var message in messages)
            {
                if (message.Message.Contains(keyword))
                {
                    result.Add(message);
                }
            }

            return result;
        }
    }
}