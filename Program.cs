using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateQueue;

namespace Lab1Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Queue<int> a = new Queue<int>();
            int cnt1 = 0;
            for(int i = 0; i < 10000; i++)
            {
                a.Enqueue(i);
            }
            for (int i = 0; i < 5000; i++)
            {
                a.Dequeue();
            }
            for (int i = 5000; i < 10000; i++)
            {
                if (a.Contains(i)) cnt1++;
            }
            stopWatch.Stop();
            Console.WriteLine($"Время затраченное на работу встроенной очереди: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"Найдено элементов во встроенной очереди: {cnt1}");

            stopWatch = new Stopwatch();
            stopWatch.Start();
            UpdateQueue<int> b = new UpdateQueue<int>();
            int cnt2 = 0;
            for (int i = 0; i < 10000; i++)
            {
                b.Enqueue(i);
            }
            for (int i = 0; i < 5000; i++)
            {
                b.Dequeue();
            }
            for(int i = 5000; i < 10000; i++)
            {
                if (b.Contains(i)) cnt2++;
            }
            stopWatch.Stop();
            Console.WriteLine($"Время затраченное на работу созданной очереди: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"Найдено элементов в созданной очереди: {cnt2}");


            UpdateQueue<int> c = new UpdateQueue<int>();
            c.Enqueue(1);
            c.Enqueue(2);
            Console.WriteLine(c.ToString());
            c.Enqueue(3);
            c.Enqueue(4);
            Console.WriteLine(c.ToString());
            c.Dequeue();
            c.Dequeue();
            Console.WriteLine(c.ToString());
            c.Enqueue(5);
            c.Enqueue(6);
            Console.WriteLine(c.ToString());
            Console.WriteLine();
            Console.WriteLine(c.Contains(1));
            Console.WriteLine(c.Contains(6));
            Console.WriteLine(c.Count);
            Console.WriteLine(c.Peek());
            
            Console.ReadKey();
        }
    }
}
