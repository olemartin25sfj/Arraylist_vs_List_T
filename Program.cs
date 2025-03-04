using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Hei");
        arrayList.Add(3.14);
        arrayList.Add(true);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}