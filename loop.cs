using System;

class loop{
	static void Main(String[] args){
		int n,i;
		Console.Write("Enter Number to Print Table : ");
		n = Convert.ToInt32(Console.ReadLine());
		for(i=1; i <= 10 ; i++){
			Console.WriteLine("{0} * {1} = {2}",n,i,n*i);	
		}
		Console.Read();
	}
}