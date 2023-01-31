using System;

class test{
    int a,b,c;
    public test(){
        a = b = c = 0;
    }
    public test(int a, int b, int c){
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public static test operator -(test obj){
        obj.a = -obj.a;
        obj.b = -obj.b;
        obj.c = -obj.c;
        return obj;
    }
    public void putdata(){
        Console.WriteLine("Value of A is : "+a);
        Console.WriteLine("Value of B is : "+b);
        Console.WriteLine("Value of C is : "+c);
    }
}
class p13{
    static void Main(String[] args){
        test obj = new test(10,20,30);
        obj = -obj;
        obj.putdata();
    }
}