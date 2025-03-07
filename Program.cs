using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Hei");
        arrayList.Add(3.14);
        arrayList.Add(true);


        List<int> list = new List<int> { 1, 1, 2, 3, 5 };

        Console.WriteLine("Innhold i ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine($"Verdi: {item}, Type: {item.GetType()}");
        }

        Console.WriteLine(new string('-', 30));

        Console.WriteLine("Innhold i List<int>:");
        foreach (var item in list)
        {
            Console.WriteLine($"Verdi: {item}");
        }



    }
}