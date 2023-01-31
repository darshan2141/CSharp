using System;
namespace writeOnlyProperty{
    class emp{
        string company_name;
        public string CompanyName{
            set{
                company_name = value;
            }
        }
        public void disp(){
            Console.WriteLine("Company Name is : "+company_name);
        }
    }
    class p27{
        public static void Main(String[] args){
            emp obj = new emp();
            obj.CompanyName = "TCS";
            obj.disp();
        }
    }
}