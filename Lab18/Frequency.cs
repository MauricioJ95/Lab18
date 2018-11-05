using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Frequency
    {
        Dictionary<int, int> Items { get; set; }
        public int[] Num { get; set; }
        public int[] Count { get; set; }

        public Frequency()
        {
            Num = new[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            Count = new int[Num.Max() + 1];
            Items = new Dictionary<int, int>();
        }
        public void CountNum()
        {
            for (int i = 0; i < Num.Length; i++)
            {
                Count[Num[i]]++;
            }
        }
        public void CountNumWithDictionary()
        {
            foreach (var item in Num)
            {
                if (Items.ContainsKey(item))
                {
                    Items[item]++;
                }
                else
                {
                    Items.Add(item, 1);
                }
            }
        } 
        public void DisplayFromDictionary()
        {
            foreach (var item in Items.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public void DisplayFromArray()
        {
            for(int i = 0; i < Count.Length; i++)
            {
                if (Count[i] > 0)
                {
                    Console.WriteLine($"{i}: {Count[i]}");
                }
            }
        }
    }
}
