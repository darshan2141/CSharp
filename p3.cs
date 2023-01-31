using System;

class p3{
	static void Main(String[] args){

		char ch;
		string str;
		int a;
		
		Console.Write("Entre Character : ");
		ch = Convert.ToChar(Console.ReadLine());
		
		Console.Write("Enter String : ");
		str = Console.ReadLine();
		Console.Write("Enter Any Integer : ");
		a = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Value of Character is : "+ch);
		Console.WriteLine("Value of String is : "+str);
		Console.WriteLine("Value of Integer is : "+a);
		Console.Read();
	}
}