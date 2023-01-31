using System;
class demo{
    int a;
    int b;
    public demo(){
        a = b = 10;
    }
    public void putdata(){
        Console.WriteLine("Value of a is :" + a);
        Console.WriteLine("Value of b is :" + b);
    }
}
class p6{
    static void Main(String[] args){
        demo obj = new demo();
        obj.putdata();
    }
}