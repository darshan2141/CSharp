using System;

class p4{
	static void Main(String[] args){
		int a,b;
		Console.Write("Enter A : ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter B : ");
		b = int.Parse(Console.ReadLine());
		if(a > b){
			Console.WriteLine("A is Greater");
		}else{
			Console.WriteLine("B is Greater");
		}
		Console.Read();
	}
}