// += add karva mate
// -= remove karva mate
using System;
public delegate void delegate_op(double a, double b);
class p41{
    static void fun_multi(double x, double y){
        Console.WriteLine("Multiplication is : " + (x * y));
    }
    static void fun_add(double x, double y){
        Console.WriteLine("Addition is : " + (x + y));
    }
    static void fun_div(double x, double y){
        Console.WriteLine("Division is : " + (x / y));
    }
    static unsafe void Main(String[] args){
        delegate_op obj = new delegate_op(fun_multi);
        obj += new delegate_op(fun_add);
        obj += new delegate_op(fun_div);
        obj(15,3);
        obj -= new delegate_op(fun_div);
        Console.WriteLine("After Remove Division");
        obj(15,3);
    }
}
