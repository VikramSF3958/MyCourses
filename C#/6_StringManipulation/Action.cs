
namespace _6_StringManipulation
{
    public class Action
    {
        public void Operation()
        {
            string input = "Syncfusion";

            System.Console.Write("Characters in Odd position: ");
            for(int i=0; i<input.Length; i++)
            {
                if(i%2==1)
                {
                    System.Console.Write($"{input[i]} ");
                }
            }
            System.Console.WriteLine();
            System.Console.Write("After replacing the letter 'n' with 'N' ");
            string newContent = "";
            for(int i=0; i<input.Length; i++)
            {
                if(input[i] == 'n')
                {
                   newContent += 'N';
                }
                else
                {
                    newContent += input[i];
                }
            }

            input = newContent;
            System.Console.WriteLine($"Replaced string: {input}");
            System.Console.WriteLine();
            System.Console.Write("Reversing Traverse: ");
            for(int i=input.Length -1; i>0;i--)
            {
                System.Console.Write($"{input[i]} ");
            }

            int count = 0;
            foreach(char character in  input)
            {
                count++;
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Length of string: {count}");

            System.Console.WriteLine();
            System.Console.Write("Enter 1st string: ");
            string string1 = Console.ReadLine();
            

            System.Console.Write("Enter 2nd string: ");
            string string2 = Console.ReadLine();
            
            int count1 = 0, Length = string2.Length - 1;
            count = 0;

            string newString = "";

            while(count <= 4)
            {
                newString += string1[count];
                count++;
            }

            while(count1 <= 3)
            {
                newString += string2[Length];
                count1++;
            }
            Length--;
            System.Console.WriteLine($"Concatenation: {newString}");

        }
    }
}