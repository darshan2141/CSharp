using System;
namespace ProIndexer{
class clsindexer{
    private string[] range = new string[5];
    public string this[int indexrange]{
        get { return range[indexrange]; }
        set { range[indexrange] = value; }
    }
}
class p34{
    public static void Main(String[] args){
        clsindexer obj = new clsindexer();
        obj[0] = "Raj";
        obj[1] = "Jay";
        obj[2] = "Ram";
        obj[3] = "Yash";
        obj[4] = "Rakesh";

        for(int i=0;i< 5;i++){
            Console.WriteLine(obj[i]);
        }
    }
}
}