//compile in visual studio
using System;
class Program
{   
    public static unsafe void printall(int* ptr){
        for (int i=0;i< 10;i++){
            Console.WriteLine(*(ptr + i));
        }
    }
    unsafe static void Main(String[] args)
    {
        int[] arr1 = new int[10];
        for (int count =0; count <10;count++)
        {
            arr1[count] = count * count;
        }
        fixed (int* ptr = arr1)
            printall(ptr);
        Console.Read();
    }
}
