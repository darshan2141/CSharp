//static class
//In static class only static data memmber and static function value inserted
//we can not created static class object
using System;
static class test{
    static int rno =1;
    static string nm ="SSSDIIT";
    public static void putdata(){
        Console.WriteLine("Value of Rno is : "+rno);
        Console.WriteLine("Value of Name is : "+nm);
    }
}
class p19{
    static void Main(String[] args){
        // test obj = new test();
        test.putdata();
    }
}