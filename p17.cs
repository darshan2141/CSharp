//call by reference using out keyword
using System;
class test{
    public void swap(out int a,out int b,int p,int q){
        a = p;
        b = q;
        Console.WriteLine("Before Swap");
        Console.WriteLine("Value of A is :"+a);
        Console.WriteLine("Value of B is :"+b);

        int c;
        c = a;
        a = b;
        b = c;
    }
}
class p17{
    static void Main(String[] args){
        int a,b;
        Console.Write("Enter A : ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter B : ");
        b = Convert.ToInt16(Console.ReadLine());

        test obj = new test();
        obj.swap(out a,out b,a,b);

        Console.WriteLine("After Swap");
        Console.WriteLine("Value of A is :"+a);
        Console.WriteLine("Value of B is :"+b);
    }
}