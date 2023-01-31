using System;
public delegate void msgpass(string message);
class msgclass{
    public static void welcome(string message){
        Console.WriteLine("Welcome "+ message);
    }
    public static void bye(string message){
        Console.WriteLine("Bye "+ message);
    }
}
class p40{
    static unsafe void Main(String[] args){
        msgpass m1 = new msgpass(msgclass.welcome);
        m1("SSSDIIT");
        m1 = msgclass.bye;
        m1("SSSDIIT");
    }
}