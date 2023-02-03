//SortedList Class And Method
using System;
using System.Collections;

class p46{
    static void Main(String[] args){
        SortedList s = new SortedList();
        s.Add("Key1", 10);
        s.Add("Key3", 30);
        s.Add("Key2", 20);

        for(int i=0;i < s.Count; i++){
            Console.WriteLine("Keys={0} and Value={1}",s.GetKey(i), s.GetByIndex(i));
        }

        Console.WriteLine("Capacity is:" + s.Capacity);
        s.TrimToSize();    
        Console.WriteLine("Now Capacity is:" + s.Capacity);
        Console.WriteLine("ContainsKey() is:" + s.ContainsKey("Key1"));
        Console.WriteLine("ConatinsValue() is:" + s.ContainsValue(40));

        ArrayList arr1 = new ArrayList();
        arr1 = ArrayList.Adapter(s.GetKeyList());

        ArrayList arr2 = new ArrayList();
        arr2 = ArrayList.Adapter(s.GetValueList());

        Console.WriteLine("Display Only Key");
        foreach (object val in arr1)
            Console.WriteLine(val);

        Console.WriteLine("Display only Value");
        foreach (object val in arr2)
            Console.WriteLine(val);

        Console.WriteLine("Indexof Key is:" + s.IndexOfKey("Key1"));
        Console.WriteLine("Index of Value:" + s.IndexOfValue(10));

        s.Remove("Key1");
        Console.WriteLine("After Remove Based on Key");
        for (int i = 0; i < s.Count; i++){
            Console.WriteLine("Keys={0} and Value={1}",s.GetKey(i), s.GetByIndex(i));
        }

        s.RemoveAt(0);
        Console.WriteLine("After Remove Based on Index");
        for (int i = 0; i < s.Count; i++){
            Console.WriteLine("Keys={0} and Value={1}",s.GetKey(i), s.GetByIndex(i));
        }
    }
}