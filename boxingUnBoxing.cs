using System;

class boxingUnboxing{
	static void Main(String[] args){
		object ans = 22;
		int a;
		a = Convert.ToInt16(ans); //unboxing
		Console.WriteLine("Value of A is :"+a);

		string nm = "sssdiit";
		object temp;
		temp = nm; //Boxing
		Console.WriteLine("Value of Temp is :"+ temp);
		Console.Read();
	}
}