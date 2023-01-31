using System;
class demo{
    static string nm;
    static demo(){ //static Constructor
         nm = "SSSDIIT";
    }
    public void putdata(){
        Console.WriteLine("Name is : " + nm);
    }
}
class p8{
    static void Main(String[] args){
        demo obj = new demo();
        obj.putdata();
    }
}