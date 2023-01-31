using System;
class student{
    int rno;
    string nm;
    public void getdata(){
        Console.Write("Enter Number : ");
        rno = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter Name : ");
        nm = Console.ReadLine();
    }
    public void putdata(){
        Console.WriteLine("Roll Number is : "+rno);
        Console.WriteLine("Name is : "+nm);
    }
}
class marks:student{
    int m1,m2,m3;
    public int total;
    public void getmarks(){
        getdata();
        Console.Write("Enter M1 : ");
        m1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter M2 : ");
        m2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter M3 : ");
        m3 = Convert.ToInt16(Console.ReadLine());
    }
    public void putmarks(){
        putdata();
        total = m1 + m2 + m3;
        Console.WriteLine("M1 is : "+m1);
        Console.WriteLine("M2 is : "+m2);
        Console.WriteLine("M3 is : "+m3);
        Console.WriteLine("Total is : "+total);
    }
}
class grade:marks{
    double per;
    public void getgrade(){
        getmarks();
        putmarks();
        per = Convert.ToDouble(total / 3);
        Console.WriteLine("Percantage is : "+per);
        if(per >= 70){
            Console.WriteLine("Distinction");
        }else if(per >= 60 && per < 70){
            Console.WriteLine("First Class");
        }else if(per >= 50 && per < 60){
            Console.WriteLine("Second Class");
        }else if(per >= 40 && per < 50){
            Console.WriteLine("Pass Class");
        }else{
            Console.WriteLine("Fail");
        }
    }
}

class p23{
    static void Main(String[] args){
        grade obj = new grade();
        obj.getgrade(); 
    }
}