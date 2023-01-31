using System;
namespace virtualMethodRunTimePolymorphism{
    class clspoly{
        int h,w;
        public int height{
            get { return h; }
            set { h = value; }
        }
        public int width{
            get { return w; }
            set { w = value; }
        }
        public virtual string display(){
            return "From base class";
        }
    }
    class clstri : clspoly{
        public override string display(){
            string ans;
            ans = "Area of Triangle is : "+(height * width * 0.5);
            return ans;
        }
    }
    class p28{
        public static void Main(String[] args){
            clspoly obj = new clstri();
            obj.height = 10;
            obj.width = 5;
            Console.WriteLine(obj.display());
        }
    }
}