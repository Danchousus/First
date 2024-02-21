using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateQueue
{
    public class UpdateQueue<T> where T : IComparable<T>
    {
        private int maxCount;
        private T[] items;
        private int head;
        private int tail;
        public int Count { get; private set; }
        public UpdateQueue()
        {
            head = 0;
            tail = 0;
            maxCount = 1;
            items = new T[maxCount];
            Count = 0;
        }
        public bool Contains(T obj)
        {
            for (int i = head; i < tail; i++)
            {
                if (items[i].CompareTo(obj) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public T Peek()
        {
            return items[head];
        }
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new Exception("Очередь пуста");
            }
            head++;
            Count--;
            return items[head - 1];
        }
        public void Enqueue(T newElement)
        {
            if (tail >= maxCount)
            {
                SizeQueue();
            }
            Count++;
            items[tail] = newElement;
            tail++;
        }
        private void SizeQueue()
        {
            T[] itemsdopmas = new T[maxCount * 2];            
            Array.Copy(items, itemsdopmas, maxCount);
            maxCount *= 2;
            items = itemsdopmas;
        }
        public override string ToString()
        {
            string output = "";
            for (int i = tail - 1; i >= head; i--)
            {
                output += items[i] + " ";
            }
            return output;
        }
    }
}