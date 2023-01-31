using System;

class p10{
	static void Main(String[] args){
		int[] a = new int[10];
		
		for(int i=0;i<a.Length;i++){
			Console.Write("Enter Value a[{0}] : ",i);
			a[i] = Convert.ToInt16(Console.ReadLine());	
		}

		for(int i=0;i<a.Length;i++){
			Console.WriteLine("a[{0}] : {1}",i,a[i]);		
		}
	}
}