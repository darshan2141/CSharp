using System;
partial class test{
    public void disp(){
        Console.WriteLine("Method Call From First Partion");
    }
}
partial class test{
    public void display(){
        Console.WriteLine("Method Call From Another Partion");
    }
}
class p18{
    static void Main(String[] args){
        test obj = new test();
        obj.disp();
        obj.display();
    }
}