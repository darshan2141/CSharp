using System;
class A{
    public string display(){
        return "From base class method";
    }
}
class B:A{
    public new string display(){
        return "From Derived class method";
    }
}
class p24{
    public static void Main(String []args){
        B obj = new B();
        Console.WriteLine(obj.display());
    }
}