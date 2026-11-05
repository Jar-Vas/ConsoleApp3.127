using System.Numerics;
using static ConsoleApp8.Program;

namespace ConsoleApp8
{
    internal class Program
    {
        public delegate bool Predicate<in T>(T t);

        static void Main(string[] args)
        {
            Predicate<int> p1 = condition1;
            Predicate<int> p2 = condition2;
            List<int> l1 = new List<int>();
            l1.Add(11);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(100);
            List<int> l2 = FilterByTwoCriteria(l1, p1, p2);
            foreach (int i in l2) { Console.WriteLine(i + " "); }
        }

        static T Max3<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T max = num1;
            if (max.CompareTo(num2) < 0) { max = num2; }
            if (max.CompareTo(num3) < 0) { max = num3; }
            return max;
        }
        static T Min3<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T min = num1;
            if (min.CompareTo(num2) > 0) { min = num2; }
            if (min.CompareTo(num3) > 0) { min = num3; }
            return min;
        }
        static T SumArr<T>(T[] arr) where T : INumber<T>
        {
            
            T sum = arr[0];
            foreach (T t in arr) { sum += t; }
            return sum - arr[0];
        }

        static public bool condition1<T>(T el) where T : IComparable { return el.CompareTo(0) > 0; }
        static public bool condition2<T>(T el) where T : IComparable { return el.CompareTo(20) < 0; }
        //static public bool condition1(int el) { return el > 10; }
        //static public bool condition2(int el) { return el < 20; }


        static List<T> FilterByTwoCriteria<T>(List<T> arr, Predicate<T> p1, Predicate<T> p2) where T : IComparable
        {
            List<T> values = new List<T>();
            foreach(T t in arr) { if (p1(t) && p2(t)) values.Add(t); }
            return values;
        }
    }
}
