using System;

class p9{
	static void Main(String[] args){
		int[] a =new int[6] {1,2,3,4,5,6};
		int[] b;
		b = new int[3] {1,2,3};
		int[] c = {11,22};
		int[] d = new int[] {5,6,7,8};
	
		for(int i=0;i<a.Length;i++){
			Console.WriteLine(a[i]);	
		} 
		Console.WriteLine("\nPrint Using foreach\n");
			
		foreach (int val in d)
		{	
			Console.WriteLine(val);
		}
	}
}