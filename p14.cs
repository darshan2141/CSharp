// enum
using System;

class p14{
    public enum Days { Monday, Tuesdar, Wednesday, Thrusday, Friday, Saturday, Sunday };
    public enum Cities { Rajkot = 76, Junagadh = 86, Gondal = 54, Jetpur = 56, Morbi=45 };
    static void Main(String[] args){
        Days day = Days.Monday;
        Console.WriteLine((int)day);
        Console.WriteLine(day);
        Cities city = Cities.Junagadh;
        Console.WriteLine("City is {0} and value is {1} ",city,(int)city);
    }   
}