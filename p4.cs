//instance data member and class data member
using System;
class cla
{
    public int add(int x, int y) //Instance Data member
    {
        return x + y;
    }
    public static int sql(int x) //class Data member
    {
        return x * x;
    }
}
class p4
{
    static void Main(String[] args)
    {
        cla obj = new cla();
        Console.WriteLine("Addition is : " + obj.add(10,20)); //Instance Data member
        Console.WriteLine("Square is : " + cla.sql(10)); //class Data member
    }
}