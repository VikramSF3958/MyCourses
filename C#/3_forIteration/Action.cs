

namespace _3_forIteration
{
    public class Action
    {
      public void Operation()
      { 

        int sum =0 ;
        System.Console.WriteLine("Enter 10 numbers: ");

        for(int i=0; i<10; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine($"Sum of entered numbers: {sum} ");
      }  
    }
}