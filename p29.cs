using System;
namespace abstractClass{
    abstract class clspoly{
        int h,y;
        public int height{
            get{ return h; }
            set{ h = value; }
        }
        public int width{
            get{ return y; }
            set{ y = value; }
        }
        public string nonabstractmethod(){
            return "Non Abstract Method";
        }
        public abstract double area();
    }
    class clsrect:clspoly{
        public override double area(){
            return height + width;
        }
    }
    class p29{
        public static void Main(String[] args){
            clsrect obj = new  clsrect();
            obj.height = 10;
            obj.width = 10;
            Console.WriteLine(obj.nonabstractmethod());
            Console.WriteLine("Area of Rectangle is : "+ obj.area());
        }
    }
}