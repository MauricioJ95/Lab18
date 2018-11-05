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
            Count = new int[Num.Max() + 1];//counting the digits and increaseing by 1 in the index
            Items = new Dictionary<int, int>();//instantiating my dictionary
        }
        public void CountNum()
        {
            for (int i = 0; i < Num.Length; i++)
            {
                Count[Num[i]]++;//counting the numbers in the array
            }
        }
        public void CountNumWithDictionary()
        {
            foreach (var item in Num)
            {
                if (Items.ContainsKey(item))
                {
                    Items[item]++;//if we find a number that comes up more than once we increase how many times it came up
                }
                else
                {
                    Items.Add(item, 1);//if a new number comes in we count 1
                }
            }
        } 
        public void DisplayFromDictionary()
        {
            foreach (var item in Items.OrderBy(i => i.Key))
            {
                /*display number then display how many times it came up.
                 Displaying from the Dictionary
                 */
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine();
        }
        public void DisplayFromArray()
        {
            for(int i = 0; i < Count.Length; i++)
            {
                if (Count[i] > 0)
                {
                    /*display from the array
                     *display number and how many times it came up
                     */
                    Console.WriteLine($"{i}: {Count[i]}");//
                }
            }
            Console.WriteLine();
        }
    }
}
