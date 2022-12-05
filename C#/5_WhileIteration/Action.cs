
namespace _5_WhileIteration
{
    public class Action
    {
        public void Operartion()
        {   
            string condition = "Y";

            while(condition == "Y")
            {
                System.Console.WriteLine("1.Chennai\n 2.Delhi\n 3. Mumbai\n 4. Kolkata");
                System.Console.Write("Enter the option: ");
                int option = int.Parse(Console.ReadLine());

                if(option == 2)
                {
                    System.Console.WriteLine("Correct");
                }else {
                    System.Console.WriteLine("Incorrect");
                }
                System.Console.WriteLine();
                System.Console.Write("Press Y to continue, Press N to close  ");
                condition = Console.ReadLine().ToUpper();
            }
        }
    }
}