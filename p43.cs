//queue Program
using System;
using System.Collections;

class queueclass{
    static void Main(String[] args){
        Queue obj = new Queue();
        obj.Enqueue(5);
        obj.Enqueue(10);
        obj.Enqueue(15);
        obj.Enqueue(20);
        obj.Enqueue(25);

        foreach (object val in obj){
            Console.WriteLine(val);
        }

        obj.Dequeue();
        obj.Dequeue();

        Console.WriteLine("After Dequeue() Method");
        foreach (object val in obj){
            Console.WriteLine(val);
        }

        Console.WriteLine("Total Element is : "+obj.Count);
        Console.WriteLine("Peek() is : "+obj.Peek());
        Console.WriteLine("Contains is : "+obj.Contains(25));

        Queue q1 = new Queue();
        q1 = (Queue)obj.Clone();

        Console.WriteLine("After Clone() Mehod");
        foreach(object val in q1){
            Console.WriteLine(val);
        }

        object[] arr1;
        arr1 = q1.ToArray();
        Console.WriteLine("After Convert into Array");
        for(int i =0;i< arr1.Length; i++){
            Console.WriteLine(arr1[i]);
        }
        q1.Clear();
    }
}