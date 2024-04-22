namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat();
            chat.AddMessage("Alice", "Hello there!");
            chat.AddMessage("Bob", "Hi, Alice!");
            chat.AddMessage("Alice", "How are you?");
            chat.AddMessage("Bob", "I'm fine, thanks!");

            string keyword = "Alice";
            List<ChatMessage> foundMessages = chat.SearchMessages(keyword);

            if (foundMessages.Count > 0)
            {
                Console.WriteLine($"Found messages containing '{keyword}':");
                foreach (var message in foundMessages)
                {
                    Console.WriteLine($"Sender: {message.Sender}, Message: {message.Message}");
                }
            }
            else
            {
                Console.WriteLine($"No messages containing '{keyword}' found.");
            }
        }
    }
}
