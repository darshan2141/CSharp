//string Array
using System;

class p15{
    static void Main(String[] args){
        string[] nm = new string[3];
        nm.SetValue("Ram",0);
        nm[1] = "Raj";
        nm[2] = "Jay";

        foreach(string val in nm){
            Console.WriteLine(val);
        }
    }
}