using System;
namespace SYBCA{
    namespace FYBCA{
        class test{
            int a,b;
            public test(int a,int b){
                this.a = a;
                this.b = b;
            }
            public void display(){
                Console.WriteLine("Addition is : "+(a+b));
            }
        }
    }
}
class p21{
    static void Main(String[] args){
        SYBCA.FYBCA.test obj = new SYBCA.FYBCA.test(10,20);
        obj.display();
    }
}