// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("DEMO Collections");

ArrayList arr = new ArrayList();

arr.Add(10);
arr.Add(20);
arr.Add(30);
arr.Add(40);
arr.Add('A');
arr.Add('B');
arr.Add('C');
arr.Add('D');
arr.Add("James");
arr.Add("Ethan");
arr.Add("Indiana");
arr.Add("Jason");
arr.Add(new Characters { Id = 1, Name = "Bond" });
arr.Add(new Characters { Id = 2, Name = "Hunt" });
arr.Add(new Characters { Id = 3, Name = "Jones" });
arr.Add(new Characters { Id = 4, Name = "Bourn" });

foreach (object rec in arr)
{
    Console.WriteLine($"Type of Entry {rec.GetType()} and Value = {rec}");
}

Console.WriteLine(  );

foreach (object rec in arr)
{
    if (rec.GetType() == typeof(int))
    {
        Console.WriteLine(rec);
    }

    if (rec.GetType() == typeof(char))
    {
        Console.WriteLine(rec);
    }

    if (rec.GetType() == typeof(string))
    {
        Console.WriteLine(rec);
    }

    if (rec.GetType() == typeof(Characters))
    {
        Console.WriteLine(((Characters)rec).Id + ((Characters)rec).Name);
    }
}



Console.ReadLine();

public class Characters
{
    public int Id { get; set; }
    public string? Name { get; set; }
}


