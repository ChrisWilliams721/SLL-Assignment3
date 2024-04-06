using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{
    [TestClass()]
    public class SLLTests
    {
        [TestMethod()]
        public void IsEmptyTest()
        {
            var empty = new SLL();
            bool result = empty.IsEmpty();
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsClear()
        {
            var empty = new SLL();
            empty.Clear();
            bool result = empty.IsEmpty();
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void AddFirstTest()
        {
            var list = new SLL();
            User user = new User(1, "Bob", "bob@example.com", "password456");
            list.AddFirst(user);

            Assert.AreEqual("Bob", list.head.Value.Name);
            Assert.AreEqual(1, list.Count());
        }
        [TestMethod()]
        public void AddLastTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Bob", "bob22@gmail.com", "password22");
            User user2 = new User(2,"Alice", "alice@example.com", "password123");

            list.AddLast(user1);
            list.AddLast(user2);

            Assert.AreEqual("Alice", list.head.Next.Value.Name);
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod()]
        public void AddAtIndexTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "password123");
            User user2 = new User(2, "Bob", "bob@example.com", "password456");
            User user3 = new User(3, "Charlie", "charlie@example.com", "password789");

            list.AddLast(user1);
            list.AddLast(user3);
            list.Add(user2, 1);

            Assert.AreEqual("Alice", list.GetValue(0).Name);
            Assert.AreEqual("Bob", list.GetValue(1).Name);
            Assert.AreEqual("Charlie", list.GetValue(2).Name);
            Assert.AreEqual(3, list.Count());

        }
        [TestMethod()]
        public void ReplaceTest()
        {
            var list = new SLL();
            User user = new User(1, "Alice", "alice@example.com", "password123");
            list.AddLast(user);

            User newUser = new User(1, "Bob", "bob@example.com", "password456");
            list.Replace(newUser, 0);

            Assert.AreEqual("Bob", list.GetValue(0).Name);
        }
        [TestMethod()]
        public void RemoveFirstTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "password123");
            User user2 = new User(2, "Bob", "bob@example.com", "password456");

            list.AddLast(user1);
            list.AddLast(user2);
            list.RemoveFirst();

            Assert.AreEqual("Bob", list.GetValue(0).Name);
            Assert.AreEqual(1, list.Count());
        }
        [TestMethod()]
        public void RemoveLastTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "password123");
            User user2 = new User(2, "Bob", "bob@example.com", "password456");

            list.AddLast(user1);
            list.AddLast(user2);
            list.RemoveLast();

            Assert.AreEqual("Alice", list.GetValue(0).Name);
            Assert.AreEqual(1, list.Count());
        }
        [TestMethod()]
        public void RemoveAtIndexTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "password123");
            User user2 = new User(2, "Bob", "bob@example.com", "password456");
            User user3 = new User(3, "Charlie", "charlie@example.com", "password789");

            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.Remove(1); 

            Assert.AreEqual("Alice", list.GetValue(0).Name);
            Assert.AreEqual("Charlie", list.GetValue(1).Name);
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod()]
        public void GetValueTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Alice", "alice@example.com", "password123");
            User user2 = new User(2, "Bob", "bob@example.com", "password456");

            list.AddLast(user1);
            list.AddLast(user2);
            User user = list.GetValue(1);

            Assert.AreEqual("Bob", user.Name);
        }
        [TestMethod()]
        public void SortByNameTest()
        {
            var list = new SLL();
            User user1 = new User(1, "Bob", "bob@example.com", "password456");
            User user2 = new User(2, "Alice", "alice@example.com", "password123");
            User user3 = new User(3, "Charlie", "charlie@example.com", "password789");

            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.SortByName();

            Assert.AreEqual("Alice", list.GetValue(0).Name);
            Assert.AreEqual("Bob", list.GetValue(1).Name);
            Assert.AreEqual("Charlie", list.GetValue(2).Name);
        }
    }
}