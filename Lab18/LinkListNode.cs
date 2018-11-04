using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class LinkListNode
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }
        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head;
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;
        }
        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
            Console.WriteLine($"Head: {Head.Data}, Tail: {Tail.Data}");
            Console.WriteLine();
        }
        public void PrintReverse()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
        public bool RemoveAt(int index)
        {
            try
            {
                Node node = GetNode(index);
                if (node == Head)
                {
                    Head = node.Next;
                }
                else
                {
                    Node previousNode = GetNode(index - 1);
                    previousNode.Next = node.Next;
                    if (node == Tail)
                    {
                        Tail = previousNode;
                    }
                }
                Count--;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool InsertAt(int index, Node n)
        {
            try
            {
                Node tempNode = GetNode(index);
                if (tempNode == Head)
                {
                    n.Next = Head;
                    Head = n;
                }
                else if(tempNode == null)
                {
                    n.Next = null;
                    Tail.Next = n;
                    Tail = n;
                }
                else
                {
                    Node previousNode = GetNode(index - 1);
                    n.Next = tempNode;
                    previousNode.Next = n;
                }
                Count++;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}


