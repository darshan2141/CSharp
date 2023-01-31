//compile in visual studio
using System;

class Program
{   
    public static unsafe void swap(int* x,int* y)
    {
        int temp;
        temp = *x;
        *x = *y;
        *y = temp;
    }
    unsafe static void Main(String[] args)
    {
        int a = 100;
        int b = 200;

        Console.WriteLine("Before Swap() : a ={0} , b ={1}", a, b);
        swap(&a,&b);
        Console.WriteLine("After Swap() : a ={0} , b={1}", a, b);
        Console.Read();
    }
}
