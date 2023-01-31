//readonly
using System;
class creClass{
	int rno;
	readonly string nm = "Raj";
	public void getdata(){
		Console.Write("Enter Roll Number : ");
		rno = Convert.ToInt16(Console.ReadLine());
		// Console.Write("Enter Name : ");
		// nm = Console.ReadLine();
	}

	public void putdata(){
		Console.WriteLine("Roll Number is : "+rno);
		Console.WriteLine("Name is : "+nm);
	}
};

class p2{
	static void Main(String[] args){	
		creClass obj = new creClass();
		obj.getdata();
		obj.putdata();
	}
}