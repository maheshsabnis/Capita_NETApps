// See https://aka.ms/new-console-template for more information
using CS_Dictionary;
using System.Text.Json;

Console.WriteLine("DEMO Dictionary");
Dictionary<int, string> simpleDictionary = new Dictionary<int, string>();

simpleDictionary.Add(1, "James");
simpleDictionary.Add(2, "Jones");
simpleDictionary.Add(3, "Jason");
simpleDictionary.Add(4, "Ethan");
simpleDictionary.Add(5, "Shrikant");
simpleDictionary.Add(6, "Tiger");
// Reading all Keys
foreach (int key in simpleDictionary.Keys)
{
    Console.WriteLine($"Key : {key}");
}

Console.WriteLine();
// Reading all values
foreach (string val in simpleDictionary.Values)
{
    Console.WriteLine($"Value : {val}");
}


simpleDictionary.TryGetValue(7, out string? value);
if(string.IsNullOrEmpty(value))
    Console.WriteLine("Record Not Found");
Console.WriteLine(value) ;

// Product Dictionary based on Category

Dictionary<string, List<Product>> products = new Dictionary<string, List<Product>>();    
// Key is String and Value is Collection
products.Add("Electronics", new List<Product>() { 
   new Product() {Id=1,Name="Laptop",Price=12000},
    new Product() {Id=2,Name="RAM",Price=2000},
     new Product() {Id=3,Name="SSD",Price=16000}
});
products.Add("Electrical", new List<Product>() {
   new Product() {Id=4,Name="Bulb",Price=2000},
    new Product() {Id=5,Name="Iron",Price=4000},
     new Product() {Id=6,Name="Mixer",Price=6000}
});
products.Add("Fashion", new List<Product>() {
   new Product() {Id=7,Name="T-Shirt",Price=200},
    new Product() {Id=8,Name="Jeans",Price=400},
     new Product() {Id=9,Name="Shirt",Price=600}
});



foreach (var key in products.Keys)
{
    Console.WriteLine(key);
}

products.TryGetValue("Electrical", out List<Product>? ectlProducts);
if (ectlProducts != null)
{
    foreach (Product prd in ectlProducts)
    {
        Console.WriteLine(JsonSerializer.Serialize(prd));
    }
}

Console.ReadLine();
