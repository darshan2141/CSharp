using System;

class Array{
	static void Main(String[] args){
		int i;
		Console.WriteLine("How to Declare Array");

		Console.WriteLine("Method ( 1 ) \n");
		int []a = new int[6]{1,2,3,4,5,6};
		for(i=0; i<= 5 ;i++){
			Console.WriteLine(a[i]);
		}	

		Console.WriteLine("Method ( 2 ) \n");
		int []b;
		b =new int[3] {1,2,3};
		 for(i=0; i<= 2 ;i++){
			Console.WriteLine(b[i]);
		}

		Console.WriteLine("Method ( 3 ) \n");
		int []c = {1,2,3,4,5};
		 for(i=0; i<= 4 ;i++){
			Console.WriteLine(c[i]);
		}

		Console.WriteLine("Method ( 4 ) \n");
		int []d =new int[]{1,2,3,4,5,6};
		 for(i=0; i<= 5 ;i++){
			Console.WriteLine(d[i]);
		}

		Console.WriteLine("Method ( 5 ) \n");
		string []nm =new string[3];
		nm.SetValue("a",0);
		nm[1] = "b";
		nm[2] = "c";
		 for(i=0; i<= 2 ;i++){
			Console.WriteLine(nm[i]);
		}
	}
}