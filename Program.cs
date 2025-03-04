using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        // ArrayList arrayList = new ArrayList();
        // arrayList.Add(1);
        // arrayList.Add("Hei");
        // arrayList.Add(3.14);
        // arrayList.Add(true);

        // foreach (var item in arrayList)
        // {
        //     Console.WriteLine(item);
        // }

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Console.WriteLine(x);

        // int x = 5;
    }
}