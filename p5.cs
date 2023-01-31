//Method overloading
//Method overloading is also known as compile time polymorphism
using System;
class cla
{
    public int add(int x, int y){
        return x + y;
    }
    public int add(int x, int y, int z){
        return x + y + z;
    }
    public int add(int x, int y, int z, int a){
        return x + y + z + a;
    }
}
class p5
{
    static void Main(String[] args){
        cla obj = new cla();
        Console.WriteLine("First Addition : " + obj.add(10, 20));
        Console.WriteLine("Second Addition : " + obj.add(10, 20 ,30));
        Console.WriteLine("Third Addition : " + obj.add(10, 20, 30 ,40));
    }
}