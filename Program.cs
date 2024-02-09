// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> itemPrices = new(){
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            };

            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
        }
    }
}
