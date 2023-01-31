using System;
class demo{
    static int a;
    static int b;
    private demo(){
         a = b = 10;
    }
    public static void putdata(){
        Console.WriteLine("Value of A is : " + a);
        Console.WriteLine("Value of B is : " + b);
    }
}
class p7{
    static void Main(String[] args){
        // demo obj = new demo();
        demo.putdata();
    }
}