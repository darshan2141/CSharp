using System;

interface ifaceproduct{
    int pid { get; set; }
    string pname { get; set; }
    double price { get; set; }
    double pro_qty(int qty);
}
class impinterface : ifaceproduct{
    int id;
    string nm;
    double cost;
    public int pid{
        get{ return id; }
        set{ id = value; }
    }
    public string pname{
        get{ return nm; }
        set{ nm = value; }
    }
    public double price{
        get{ return cost; }
        set{ cost = value; }
    }
    public double pro_qty(int qty){
        return price * qty;
    }
}
class p32{
    public static void Main(String[] args){
        int qty;
        impinterface obj = new impinterface();
        Console.Write("Enter Product Id : ");
        obj.pid = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter Product Name : ");
        obj.pname = Console.ReadLine();
        Console.Write("Enter Product Price : ");
        obj.price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Quantity : ");
        qty = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Id is : " + obj.pid);
        Console.WriteLine("Name is : " + obj.pname);
        Console.WriteLine("Price is : " + obj.price);
        Console.WriteLine("Total Cost is : " + obj.pro_qty(qty));
    }
}
