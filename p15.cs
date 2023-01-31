//method call by value
using System;
class test{
    public void swap(int a,int b){
        Console.WriteLine("Before Swap");
        Console.WriteLine("Value of A is : "+ a);
        Console.WriteLine("Value of B is : "+ b);

        int c;
        c = a;
        a = b;
        b = c;

        Console.WriteLine("After Swap");
        Console.WriteLine("Value of A is : "+ a);
        Console.WriteLine("Value of B is : "+ b);
    }
}
class p15{
    static void Main(String[] args){
        int a,b;
        Console.Write("Enter A : ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter B : ");
        b = Convert.ToInt16(Console.ReadLine());

        test obj = new test();
        obj.swap(a,b);
    }   
}