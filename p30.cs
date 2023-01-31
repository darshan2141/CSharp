using System;
namespace sealedClass{
    sealed class claseal{
        int x,y;
        public int X{
            get{ return x; }
            set{ x = value; }
        }
        public int Y{
            get{ return y; }
            set{ y = value; }
        }
        public int multi(){
            return x*y;
        }
    }
    class p30{
        public static void Main(String []args){
            claseal obj = new claseal();
            obj.X = 10;
            obj.Y = 20;
            Console.WriteLine("Multiplication is : "+obj.multi());
        }
    }
}