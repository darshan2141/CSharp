using System;
public delegate void deleagte_op();
class p39{
    static void HI(){
        Console.WriteLine("Hello");
    }
    static void Welcome(){
        Console.WriteLine("Welcome To Delegate");
    }
    public static void Main(String[] args){
        deleagte_op objdel = new deleagte_op(HI);
        objdel();
        objdel = Welcome;
        objdel();   
    }
}