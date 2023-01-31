//get value from user Multidimension Array
using System;
class p12{
    static void Main(String[] args){
        int[,] a = new int[2,2];
        for(int i=0;i<2;i++){
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Enter a[{0},{1}] :",i,j);
                a[i,j]= Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for(int i=0;i<2;i++){
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Enter a[{0},{1}] : {2}",i,j,a[i,j]);
            }
        }
    }
}