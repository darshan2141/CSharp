using System;
namespace SYBCA{
    class test{
        public void display(){
            Console.WriteLine("Single Namespace Example");
        }
    }
}
class p20{
    static void Main(String[] args){
        SYBCA.test obj = new SYBCA.test();
        obj.display();
    }
}