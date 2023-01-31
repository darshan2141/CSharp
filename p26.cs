using System;
namespace readOnlyProperty{
    class clsEmp{
        public string CompanyName{
            get{
                return "Wipro";
            }
        }
    }
    class p26{
        public static void Main(String[] args){
            clsEmp obj = new clsEmp();
            Console.WriteLine("Company Name is :"+obj.CompanyName);
        }
    }
}