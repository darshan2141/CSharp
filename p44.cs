using System;
using System.Collections;

class p44{
    static void Main(String[] args){
        ArrayList ar1 = new ArrayList();
        ar1.Add("Raj");
        ar1.Add("Ayush");
        ar1.Add("Harsh");
        ar1.Add("Krish");
        ar1.Add("Yash");

        foreach(object val in ar1){
            Console.WriteLine(val);
        }

        Stack s1 = new Stack();
        s1.Push(1);
        s1.Push(2);
        s1.Push(3);
        s1.Push(4);
        ar1.AddRange(s1);

        Console.WriteLine("After AddRange()");
        foreach(object val in ar1){
            Console.WriteLine(val);
        }

        ArrayList ar2 = new ArrayList();
        ar2.Add(10);
        ar2.Add(15);
        ar2.Add(20);

        Console.WriteLine("=============");
        foreach(object val in ar2)
            Console.WriteLine(val);

        Console.WriteLine("BinarySearch() is : "+ar2.BinarySearch(20));

        ar2.Insert(1,25);
        Console.WriteLine("After Insert Method");
        foreach(object val in ar2)
            Console.WriteLine(val);

        ar2.InsertRange(2,s1);
        Console.WriteLine("After InsertRange Method");
        foreach(object val in ar2)
            Console.WriteLine(val);

        ar2.RemoveRange(3,5);
        Console.WriteLine("After Remove Range Method");
        foreach(object val in ar2)
            Console.WriteLine(val);

        ar2.RemoveAt(0);
        Console.WriteLine("After Remove At Method");
        foreach(object val in ar2)
            Console.WriteLine(val);

        ar2.Remove(4);
        Console.WriteLine("After Remove Method");
        foreach (object val in ar2)
            Console.WriteLine(val);
        
        Console.WriteLine("Total Element is: " + ar2.Count);
        Console.WriteLine("Contains() is:" + ar2.Contains(25));
        Console.WriteLine("Capacity() is : " + ar2.Capacity);

        ar2.Capacity = 50;
        Console.WriteLine("After Set Capacity() is : " + ar2.Capacity);

        ar2.TrimToSize();
            Console.WriteLine("After TrimToSize Capacity is : " + ar2.Capacity);
    }
}