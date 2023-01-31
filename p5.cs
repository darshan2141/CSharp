// Switch Case Program
using System;

class p5{
	static void Main(String[] args){
		char ch;
		Console.WriteLine("a : Monday");
		Console.WriteLine("b : TuesDay");
		Console.WriteLine("c : WednesDay");
		Console.WriteLine("d : ThrusDay");
		Console.WriteLine("e : FriDay");
		Console.WriteLine("f : SaturDay");
		Console.WriteLine("g : SunDay");
		Console.Write("Enter Your Choice : ");
		
		ch = Convert.ToChar(Console.ReadLine());
		switch(ch){
			case 'a' : Console.WriteLine("Monday");
			break;
			case 'b' : Console.WriteLine("Tuesday");
			break;
			case 'c' : Console.WriteLine("Wednesday");
			break;
			case 'd' : Console.WriteLine("Thrusday");
			break;
			case 'e' : Console.WriteLine("Friday");
			break;
			case 'f' : Console.WriteLine("Staurday");
			break;
			case 'g' : Console.WriteLine("Sunday");
			break;
			default: Console.WriteLine("Your choice is not matched");
			break;
		}

		Console.Read();
	}
}