public delegate double delegate_op(double a,double b);
class Program { 
    static double fun_multi(double x,double y)
    {
        return x * y;
    }
    static double fun_add(double x,double y)
    {
        return x + y;
    }

    private static unsafe void Main(String []args)
    {
        delegate_op objdel1 = new delegate_op(fun_multi);
        delegate_op objdel2 = new delegate_op(fun_add);
        Console.Write("Enter Value 1 : ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Value 2 : ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        double ans1 = objdel1(n1, n2);
        Console.WriteLine("Multiplication is : "+ ans1);
        double ans2 = objdel2(n1, n2);
        Console.WriteLine("Addition is : "+ ans2);
        Console.Read();
    }
}

