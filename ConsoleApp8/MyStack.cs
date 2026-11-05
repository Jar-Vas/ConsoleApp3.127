using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ConsoleApp8
{
    internal class MyStack<T> 
    {
        public List<T> MyArr { get; set; }
        public MyStack(List<T> arr) { MyArr = arr; }
        public MyStack() { MyArr = new List<T> { }; }

        public void Pop() { MyArr.RemoveAt(MyArr.Count - 1); }
        public void Push(T el) { MyArr.Add(el); }
        public T Peek() { return MyArr[MyArr.Count - 1]; }
        public int Count() { return MyArr.Count; }
    }
}
