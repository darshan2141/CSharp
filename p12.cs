using System;
class test{
    int a;
    int b;
    private test(){
        a = b =0;
    }
    private test(int a):this(){
        this.a = a;
    }
    public test(int a,int b):this(a){
        this.b = b;
    }
    public void putdata(){
        Console.WriteLine("Value of A is : "+a);
        Console.WriteLine("Value of B is : "+b);
    }
}
class p12{
    static void Main(String[] args){
        test obj = new test(20,30);
        obj.putdata();
    }   
}