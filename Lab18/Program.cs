using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListNode l = new LinkListNode();

            //values for my linked list
            l.Add("Dave");
            l.Add("Shark");
            l.Add("Coco");
            l.Add("Sylvia");
            l.Add("Mama");

            //prints list
            l.PrintList();

            Console.ReadKey();

            //insert at index 2
            l.InsertAt(2, new Node("Grandpa", null));
            //print
            l.PrintList();
            //print in reverse
            l.PrintReverse();

            Console.ReadKey();
            //Remove at index 2
            l.RemoveAt(2);
            //print
            l.PrintList();
            //print in reverse
            l.PrintReverse();

            Console.ReadKey();
            //calling my constructors
            var f = new Frequency();

            f.CountNum();

            f.CountNumWithDictionary();

            f.DisplayFromArray();

            f.DisplayFromDictionary();

            Console.ReadKey();
        }
    }
}
