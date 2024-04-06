using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class SLL : ILinkedListADT
    {
        public Node head;
        public int size;

        public SLL()
        {
            head = null; size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void Clear()
        {
            head = null;
            size = 0;
        }
        public void AddLast(User value)
        {
            if (IsEmpty())
            {
                head = new Node(value);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }
            size++;
        }
        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            size++;
        }
        public void Add(User value, int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                AddFirst(value);
            }
            else if (index == size)
            {
                AddLast(value);
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                Node newNode = new Node(value);
                newNode.Next = current.Next;
                current.Next = newNode;
                size++;
            }
        }
        public void Replace(User value, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = value;
        }
        public int Count()
        {
            return size;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new CannotRemoveException("List is empty.");
            }

            head = head.Next;
            size--;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new CannotRemoveException("List is empty.");
            }

            if (size == 1)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            size--;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == size - 1)
            {
                RemoveLast();
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                size--;
            }

        }
        public User GetValue(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        public int IndexOf(User value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }
        public void SortByName()
        {
            List<User> userList = new List<User>();
            Node current = head;
            while (current != null)
            {
                userList.Add(current.Value);
                current = current.Next;
            }

            userList = userList.OrderBy(u => u.Name).ToList();

            Clear();
            foreach (User user in userList)
            {
                AddLast(user);
            }
        }

    }
}
