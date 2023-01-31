//Constructor Overloading
using System;
class test{
    int a;
    int b;
    static string nm;
    public test(){ //default constructor
        a = b = 10;
    }
    public test(int a , int b){ //parameterized constructor
        this.a = a;
        this.b = b;
    }
    static test(){ //static constructor
        nm = "SSSDIIT";
    }
    public void putdata(){
        Console.WriteLine("Value of A is : " + a);
        Console.WriteLine("Value of B is : " + b);
        Console.WriteLine("Value of nm is : " + nm);
    }
}
class p11{
    static void Main(String[] args){
        int a ,b;
        Console.Write("Enter A : ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter B : ");
        b = Convert.ToInt16(Console.ReadLine());
        test obj = new test(a,b);
        obj.putdata();
    }
}