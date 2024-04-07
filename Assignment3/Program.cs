using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User(1, "John", "john@example.com", "password1");
            User user2 = new User(2, "Alice", "alice@example.com", "password2");
            User user3 = new User(3, "Bob", "bob@example.com", "password3");

            SLL linkedList = new SLL();
            linkedList.AddFirst(user1);
            linkedList.AddLast(user2);
            linkedList.AddFirst(user3);

            // Serialize the linked lis

            Console.WriteLine("Serialization Completed");
        }
    }
}
