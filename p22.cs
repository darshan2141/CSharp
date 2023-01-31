using System;
class A{
    int a;
    public A(int a){
        this.a = a;
    }
    public void display(){
        Console.WriteLine("Value of A is :"+a);
    }
}
class B:A{
    int b;
    public B(int a,int b):base(a){
        this.b = b;
    }
    public void disp(){
        display();
        Console.WriteLine("Value of B is : "+b);
    }
}
class p22{
    static void Main(String[] args){
        B obj = new B(10,20);
        obj.disp();
    }
}