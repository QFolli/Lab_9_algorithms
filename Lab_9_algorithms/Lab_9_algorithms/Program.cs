using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2. Код
            Console.WriteLine("Введите два натуральных числа S и K, представляющих сумму и количество цифр соответственно (K <= 100):");
            string[] temp = Console.ReadLine().Split(' ');
            int S = Int32.Parse(temp[0]);
            int K = Int32.Parse(temp[1]);
            List<int> list = new List<int>();
            int[] maximum = new int[K];
            int[] minimum = new int[K];
            string max = "", min = "";
            int n, m = 0;
            int a = 0, b = 0, c = S;
            for (int i = 9; i > 0; i--)
            {
                n = S / i;
                for (int j = m; j < m + n; j++)
                {
                    list.Add(i);
                }
                m += n;
                S = S % i;
                if (S == 0) break;
            }
            S = c;
            a = 0;
            b = 0;
            c = 0;
            while (true)
            {
                b += list[a];
                if (b <= S)
                {
                    maximum[a] = list[a];
                    c++;
                    if (b == S) break;
                }
                else
                {
                    b -= list[a];
                }
                a++;
            }
            list[list.IndexOf(list.Min())]--;
            minimum[0] = 1;
            a = 0;
            b = 1;
            c = K - 1;
            while (true)
            {
                b += list[a];
                if (b <= S)
                {
                    minimum[c] = list[a];
                    if (b == S) break;
                }
                a++; c--;
            }
            foreach (var item in maximum)
            {
                max += item;
            }
            foreach (var item in minimum)
            {
                min += item;
            }
            Console.WriteLine("Наибольшее и наименьшее возможные значения: {0} и {1}", max, min);
            Console.ReadLine();
        }
    }
}
