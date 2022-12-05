namespace _4_Array
{
    class Program 
    {
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("SORTING");
            Operations obj = new Operations();
            obj.Sorting();
            System.Console.WriteLine();
            System.Console.WriteLine("Print ODD and EVEN from the ARRAY");
            obj.PrintOddEven();
        }
    }
}