// method call by reference using ref Kyeword
using System;
class test{
    public void swap(ref int a, ref int b){
        Console.WriteLine("Before Swap");
        Console.WriteLine("Value of A is : "+a);
        Console.WriteLine("Value of B is : "+b);

        int c;
        c = a;
        a = b;
        b = c;
    }
}
class p16{
    static void Main(String[] args){
        int a,b;
        Console.Write("Enter A : ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter B : ");
        b = Convert.ToInt16(Console.ReadLine());

        test obj = new test();
        obj.swap(ref a, ref b);

        Console.WriteLine("After Swap");
        Console.WriteLine("Value of A is : "+a);
        Console.WriteLine("Value of B is : "+b);
    }
}