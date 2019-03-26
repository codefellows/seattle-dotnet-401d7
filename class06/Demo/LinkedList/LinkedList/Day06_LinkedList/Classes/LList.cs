using System;
using System.Collections.Generic;
using System.Text;

namespace Day06_LinkedList.Classes
{
	class LList
	{
		/// <summary>
		///		Always points to the first node in the LL
		/// </summary>
		public Node Head { get; set; }

		/// <summary>
		///		The node that is used to traverse through the LL
		/// </summary>
		public Node Current { get; set; }

		/// <summary>
		///		LL requires a node at time of creation to be the HEAD
		/// </summary>
		/// <param name="node">the node that will become the head</param>
		public LList(Node node)
		{
			Head = node;
			Current = node;
		}

		/// <summary>
		/// Add a node to the beginning of the LL (sometimes called Insert)
		/// time: O(1)
		/// space: O(1)
		/// </summary>
		/// <param name="node">the node that will be added</param>
		public void Add(Node node)
		{
			Current = Head;
			node.Next = Head;
			Head = node;
			Current = Head;
		}

		/// <summary>
		///	Prints the list node by node to the console
		///	time: O(n)
		///	space: O(1)
		/// </summary>
		public void Print()
		{
			Current = Head;

			while (Current.Next != null)
			{
				Console.Write($"{Current.Value} --> ");
				Current = Current.Next;
			}

			Console.Write($"{Current.Value} --> NULL\n");
			Current = Head;
		}


		/// <summary>
		/// Appends a node to the end of the LL
		/// time: O(n)
		/// space: O(1)
		/// </summary>
		/// <param name="newNode">the node to be added</param>
		public void Append(Node newNode)
		{
			Current = Head;
			while (Current.Next != null)
			{
				Current = Current.Next;
			}

			Current.Next = newNode;
			Current = Head;
		}

		/// <summary>
		/// inserts a node into the list before a given node
		/// time: O(n)
		/// space: O(1)
		/// </summary>
		/// <param name="newNode">the node to be added</param>
		/// <param name="existingNode">the node that will follow the newly added node</param>
		public void AddBefore(Node newNode, Node existingNode)
		{
			Current = Head;
			if (Head.Value == existingNode.Value)
			{
				Add(newNode);
				return;
			}

			while (Current.Next != null)
			{
				if (Current.Next.Value == existingNode.Value)
				{
					newNode.Next = existingNode;
					Current.Next = newNode;
					return;
				}
				Current = Current.Next;
			}
		}
	}
}
