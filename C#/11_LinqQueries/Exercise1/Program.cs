namespace Exercise1;

class Program 
{   
    public static List<string> Places = new List<string>();
    public static void Main(string[] args)
    {
        Places.Add("ABU DHABI");
        Places.Add("AMSTERDAM");
        Places.Add("ROME");
        Places.Add("MADURAI");
        Places.Add("LONDON");
        Places.Add("NEW DELHI");
        Places.Add("MUMBAI");
        Places.Add("NAIROBI");
        Console.Clear();
        
        System.Console.Write("Input Starting Character of the string: ");
        char firstCharacter = char.Parse(Console.ReadLine());
        
        System.Console.Write("Input ending character for the string: ");
        char lastCharacter = char.Parse(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.WriteLine($"The City Starting with {firstCharacter} and Ending with {lastCharacter}");
        
        IEnumerable<string> QueryResult = Places.Where(temp => temp.First() == firstCharacter && temp.Last() == lastCharacter);  

        for(int i=0; i<QueryResult.Count(); i++)
        {
            System.Console.WriteLine($"{QueryResult.ElementAt(i)}");
        }
    
    }
}