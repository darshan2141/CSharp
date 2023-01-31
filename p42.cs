//stack Program
using System;
using System.Collections;

class p42{
    static void Main(string[] args){
        Stack obj = new Stack();
        obj.Push(5);
        obj.Push(10);
        obj.Push(15);
        obj.Push(20);
        obj.Push(25);

        foreach (int val in obj){
            Console.WriteLine (val);
        }

        obj.Pop();
        obj.Pop();
        Console.WriteLine("After POP() Operation");

        foreach (int val in obj){
            Console.WriteLine (val);
        }

        Console.WriteLine("Peek() Operation is : "+ obj.Peek());
        Console.WriteLine("Total Element is : "+ obj.Count);
        Console.WriteLine("Contains() Result is : "+ obj.Contains(3));

        Stack s1 = new Stack();
        s1 = (Stack)obj.Clone();

        Console.WriteLine("After Clone Method");

        foreach(int val in s1){
            Console.WriteLine(val);
        }

        object[] arr1;
        arr1 = s1.ToArray();
        Console.WriteLine("After Convert into array");

        for(int i = 0; i< arr1.Length; i++){
            Console.WriteLine(arr1[i]);
        }

        s1.Clear();
    }
}
