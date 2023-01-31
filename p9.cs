using System;
class demo{
    int a;
    int b;
    public demo(int x,int y){ //parameterized Constructor
         a = x;
         b = y;
    }
    public void putdata(){
        Console.WriteLine("Value of A is : " + a);
        Console.WriteLine("Value of B is : " + b);
    }
}
class p9{
    static void Main(String[] args){
        demo obj = new demo(10,20);
        obj.putdata();
    }
}