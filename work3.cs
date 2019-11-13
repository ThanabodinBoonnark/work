using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>();
        var price = new List<double>();
        string sumname = null;
        int While = 0;
        var reader = System.IO.File.ReadAllLines(@"D:\test.csv");
        Console.WriteLine("             [item]");
        var skip = reader.Skip(1);
        foreach (var item in skip)
        {
            var values = item.Split(',');
            var product = new Product
            {
                SKU = values[0],
                Name = values[1],
                Price = Double.Parse(values[2])
            }; Console.WriteLine(values[0] + "  " + values[1] + ": " + values[2]);
            products.Add(product);
        }
        Console.WriteLine("\n---------------------------");
        while (While < 1)
        {
            Console.WriteLine("\nPlease input a product key");
            var input = System.Console.ReadLine();
            var PD = products.FirstOrDefault(it => it.SKU == input);
            price.Add(PD.Price);
            var sumprice = price.Sum();
            foreach (var item in PD.Name)
            {
                sumname += item;
            }   sumname += "\n";
            Console.WriteLine($"--------------------------\nProducts in your cart are \n{sumname}\n---------------------------\nTotal amount: {sumprice} baht\n---------------------------");
        }
    }
}
internal class Product
{
    public string SKU { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}