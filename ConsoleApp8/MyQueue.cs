using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class MyQueue<T>
    {
        public List<T> MyArr { get; set; }
        public MyQueue() { MyArr = new List<T>(); }
        public MyQueue(List<T> arr) { MyArr = arr; }

        public void enqueue(T el) { MyArr.Add(el); }
        public void dequeue(T el) { MyArr.RemoveAt(0); }
        public T peek() { return MyArr[MyArr.Count - 1]; }
        public int count() { return MyArr.Count; }  
    }
}
