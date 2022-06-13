using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.3. Расписание
            Console.Write("Введите количество заявок (N <= 1000) \nN = ");
            int n = Int32.Parse(Console.ReadLine());
            Random rand = new();
            string[] lecture; int s, f;
            int count = 0, bufer = 0;
            SortedDictionary<int, List<int>> list = new SortedDictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                lecture = Console.ReadLine().Split(' ');
                if (list.ContainsKey(Int32.Parse(lecture[0])))
                {
                    list[Int32.Parse(lecture[0])].Add(Int32.Parse(lecture[1]));
                }
                else
                {
                    list[Int32.Parse(lecture[0])] = new List<int>();
                    list[Int32.Parse(lecture[0])].Add(Int32.Parse(lecture[1]));
                }
            }
            foreach (var item in list)
            {
                if (item.Key >= bufer)
                {
                    count++;
                    bufer = item.Value.Min();
                }
                else
                {
                    if (item.Value.Min() < bufer)
                    {
                        bufer = item.Value.Min();
                    }
                }
            }
            Console.WriteLine("Максимальное количество заявок: ", count);
            Console.ReadLine();
        }
    }
}
