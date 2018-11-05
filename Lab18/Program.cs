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

            l.Add("Dave");
            l.Add("Shark");
            l.Add("Coco");
            l.Add("Sylvia");
            l.Add("Mama");

            l.PrintList();

            //l.PrintReverse();

            Console.ReadKey();

            l.InsertAt(2, new Node("Grandpa", null));

            l.PrintList();
            l.PrintReverse();

            Console.ReadKey();

            l.RemoveAt(2);

            l.PrintList();
            l.PrintReverse();

            Console.ReadKey();

            var f = new Frequency();

            f.CountNum();

            f.CountNumWithDictionary();

            f.DisplayFromArray();

            f.DisplayFromDictionary();

            Console.ReadKey();
        }
    }
}
