using System;
using System.Collections.Generic;
using Class05_LinkedList;

namespace CircularLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{

			Node node = new Node(4);
			Node node1 = new Node(8);
			Node node2 = new Node(15);
			Node node3 = new Node(16);
			Node node4 = new Node(23);
			Node node5 = new Node(42);

			LinkList linkList = new LinkList(node);
			linkList.AddLast(node2);
			linkList.AddLast(node3);
			linkList.AddLast(node4);
			linkList.AddLast(node5);
			linkList.AddLast(node3);

			IsCircularHash(linkList);
			IsCircularRace(linkList);
		}

		// Big O Time = O(n)
		// Since the tortoise is going 1 by 1, it will eventually end up on the same as the hare.. 
		// Big O Space = O(1) 
		// no extra space is being used. 
		static bool IsCircularRace(LinkList linkList)
		{
			Node tortoise = linkList.Head, hare = linkList.Head;
			if (hare.Next == null)
			{
				return false;
			}
			else
			{
				hare = hare.Next;
				while (hare.Next != null)
				{
					hare = hare.Next;
					tortoise = tortoise.Next;

					if (hare == tortoise)
					{
						return true;
					}
					else
					{
						if (hare.Next != null)
						{
							hare = hare.Next;

						}
					}
				}
			}
			return false;
		}

		// Big O Time: O(n) 
		//N for the number of nodes in the linked list. it's possible it isn't circular
		// Big O Space:O(n) //
		// Worst case, there is not a circular reference and we are adding all of the nodes into the hashset, therefore adding more space. 
		static bool IsCircularHash(LinkList linkList)
		{
			HashSet<Node> myNodes = new HashSet<Node>();
			while (linkList.Current.Next != null)
			{
				if (myNodes.Add(linkList.Current))
				{
					linkList.Current = linkList.Current.Next;
				}
				else
				{
					return true;
				}

			}
			return false;
		}

	}
}
