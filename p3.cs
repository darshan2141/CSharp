//instance data member and class data member
using System;
class cla
{
    public int rno = 1; //Instance Data member
    public static string nm = "BCA"; //class Data member
}
class p3
{
    static void Main(String[] args)
    {
        cla obj = new cla();
        Console.WriteLine("Rno is : " + obj.rno); //Instance Data member
        Console.WriteLine("Name is : " + cla.nm); //class Data member
        Console.Read();
    }
}