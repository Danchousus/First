using System;
using Xunit;
using UpdateQueue;

namespace TestQueue
{
    public class UnitTest1
    {
        [Fact]
        public void TestDequeue()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(1);
            queue.Dequeue();
        }

    }
}
