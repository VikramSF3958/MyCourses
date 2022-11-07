
namespace OrderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderTotal obj = new OrderTotal();

            obj.Price1 = int.Parse(System.Console.ReadLine());

            obj.Price2 = int.Parse(System.Console.ReadLine());

            obj.Discount = int.Parse(System.Console.ReadLine());

            obj.Country = System.Console.ReadLine();

            //Output
            var result = obj.OrderTotalPrice();

            System.Console.WriteLine(result);

        }
    }
}
