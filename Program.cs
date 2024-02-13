// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    internal class Program
    {
        private static int totalValue;

        static void Main(string[] args)
        {
            /*
            Dictionary<string, decimal> itemPrices = new(){
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            };

            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
            */

            int[] ArrayToSum = [24, 100, 100, 50, 40, 65];

            totalValue = GetSum(ArrayToSum);

            Console.WriteLine(totalValue);
        }

        static private int GetSum(int[] ArrayToSum)
        {
            int totalValue = 0;
            foreach(int number in ArrayToSum)
            {
                totalValue += number;
            }
            if(totalValue > 300)
            {
                return totalValue;
            }
            return 0;
        }
    }
}
