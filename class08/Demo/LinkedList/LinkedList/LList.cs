using System.Collections.Generic;

namespace LinkedList
{
    public class LList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Current { get; set; }

        /// <summary>
        /// Inserting a new value into the beginning of the linked list.
        /// </summary>
        /// <param name="value">the value to be inserted into the linked list</param>
        public void Insert(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Determines if a specific value lives within the linked list
        /// </summary>
        /// <param name="value">value to be search</param>
        /// <returns>determines if the value exists</returns>
        public bool Includes(T value)
        {
            Current = Head;

            while (Current != null)
            {
                if (Current.Value.Equals(value))
                {
                    return true;
                }
                Current = Current.Next;
            }

            return false;
        }

        /// <summary>
        /// Collect all of the values into the Linked List through a traversal
        /// </summary>
        /// <returns>A collection of all the linked list values</returns>
        public List<T> Print()
        {
            Current = Head;
            List<T> values = new List<T>();

            while (Current != null)
            {
                values.Add(Current.Value);
                Current = Current.Next;
            }

            return values;
        }

        /// <summary>
        /// Add a new node to the end of the Linked List
        /// </summary>
        /// <param name="value">value for new Linked List node</param>
        public void Append(T value)
        {
            Current = Head;
            Node<T> node = new Node<T>(value);

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;

        }

        /// <summary>
        /// Insert a new node before a specific value within a linked list
        /// </summary>
        /// <param name="value">existing value of node in the Linked List</param>
        /// <param name="newValue">new value to be added into the linked list</param>
        public void InsertBefore(T value, T newValue)
        {
            Node<T> current = Head;
            Node<T> newNode = new Node<T>(newValue);

            if (current.Value.Equals(value))
            {
                Insert(newValue);

            }
            else
            {
                while (current.Next != null)
                {
                    if (current.Next.Value.Equals(value))
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }

                    current = current.Next;
                }
            }


        }

        /// <summary>
        /// Insert a new node after a specific value within a linked list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertAfter(T value, T newValue)
        {
            Current = Head;
            Node<T> newNode = new Node<T>(newValue);

            while (Current != null)
            {
                if (Current.Value.Equals(value))
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }

                Current = Current.Next;
            }
        }

    }
}
