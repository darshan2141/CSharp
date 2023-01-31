using System;
class Base{
    public  virtual string display(){
        return "From Base Class";
    }
}
class Derive:Base{
    public sealed override string display(){
        return base.display()+"\nFrom Derived Class";
    }
}
class p31{
    public static void Main(String[] args){
        Derive obj = new Derive();
        Console.WriteLine(obj.display());
    }
}
