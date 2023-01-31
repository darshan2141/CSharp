using System;
class clsEmp{
    int emp_no;
    string emp_nm;
    public int EmpNumber{
        get{
            return emp_no;
        }
        set{
            emp_no = value;
        }
    }
    public string EmpName{
        get{
            return emp_nm;
        }
        set{
            emp_nm = value;
        }
    }
    public void disp(){
        Console.WriteLine("Employee Number is : " + emp_no);
        Console.WriteLine("Employee Name is : " + emp_nm);
    }
}
class p25{
    public static void Main(String[] args){
        clsEmp obj = new clsEmp();
        obj.EmpNumber = 1;
        obj.EmpName = "Jack";
        obj.disp();
        Console.Read();
    }
}
