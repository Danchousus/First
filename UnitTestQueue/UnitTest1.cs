using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UpdateQueue;

namespace UnitTestQueue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDequeueException()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Dequeue();
        }
        [TestMethod]
        public void TestContains()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(true, queue.Contains(1));
        }
        [TestMethod]
        public void TestPeek()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Peek());
        }
        [TestMethod]
        public void TestDequeueReturn()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Dequeue());
        }
        [TestMethod]
        public void TestCount()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(2);
            Assert.AreEqual(1, queue.Count);
        }
        [TestMethod]
        public void TestDequeue()
        {
            UpdateQueue<int> queue = new UpdateQueue<int>();
            queue.Enqueue(1);
            queue.Dequeue();
            Assert.AreEqual(0, queue.Count);
        }
    }
}
