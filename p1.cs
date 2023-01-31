using System;

class creClass{
	int rno;
	string nm;
	
	public void getdata(){
		Console.Write("Enter Roll Number : ");
		rno = Convert.ToInt16(Console.ReadLine());
		Console.Write("Enter Name : ");
		nm = Console.ReadLine();
	}

	public void putdata(){
		Console.WriteLine("Roll Number is : "+rno);
		Console.WriteLine("Name is : "+nm);
	}
};

class p1{
	static void Main(String[] args){	
		creClass obj = new creClass();
		obj.getdata();
		obj.putdata();
	}
}