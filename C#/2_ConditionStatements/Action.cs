

namespace _2_ConditionStatements
{
    public class Action
    {
       public void Operation()
       {
            System.Console.WriteLine("Enter the Grade: ");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            if(grade == 'A')
            {
                System.Console.WriteLine("Grade A denotes 9 Points");
            }
            else
            if(grade == 'B')
            {
                System.Console.WriteLine("Grade B denotes 8 Points");
            }
            else
            if(grade == 'C')
            {
                System.Console.WriteLine("Grade C denotes 7 Points");
            }
            else
            if(grade == 'D')
            {
                System.Console.WriteLine("Grade D denotes 6 Points");
            }
            else
            {
                System.Console.WriteLine("This is not valid Grade");
            }
            
       } 
    }
}