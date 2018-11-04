using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Node
    {
        public string Data
        {
            set; get;
        }
        public Node Next { set; get; }

        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }
        public Node()
        {

        }
    }
}
