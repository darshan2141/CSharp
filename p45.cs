//Hashtable Class
//uncomplete program
using System;
using System.Collections;

class p45{
    static void Main(String[] args){
        Hashtable h1 = new Hashtable();
        h1.Add("Key1", 1);
        h1.Add("Key2", 4);
        h1.Add("Key3", 2);
        h1.Add("Key4", 3);
        h1["Key5"] = 5;

        foreach (DictionaryEntry snamee in h1){
            Console
                .WriteLine("Key ={0} and Value ={1}", snamee.Key, snamee.Value);
        }
    }
}
