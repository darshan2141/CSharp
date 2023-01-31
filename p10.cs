using System;
class demo{
    int a;
    int b;
    public demo(int a,int b){
         this.a = a; //this keyword
         this.b = b; //this keyword
    }
    public void putdata(){
        Console.WriteLine("Value of A is : " + a);
        Console.WriteLine("Value of B is : " + b);
    }
}
class p9{
    static void Main(String[] args){
        demo obj = new demo(20,30);
        obj.putdata();
    }
}