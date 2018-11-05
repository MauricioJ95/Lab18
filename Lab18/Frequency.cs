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
        public int[] num { get; set; }
        public int[] count { get; set; }

        public Frequency()
        {
            num = new[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            count = new int[num.Max() + 1];
        }
        public void CountNum()
        {
            for (int i = 0; i < num.Length; i++)
            {
                count[num[i]]++;
            }
        }
        public void CountNumWithDictionary()
        {
            foreach (var item in num)
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
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public void DisplayFromArray()
        {
            for(int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i}: {count[i]}");
                }
            }
        }
    }
}
