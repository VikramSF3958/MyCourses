namespace Exercise2;

class Program 
{
    public static List<string> Places = new List<string>();
    public static void Main(string[] args)
    {
        Places.Add("ABU DHABI");
        Places.Add("AMSTERDAM");
        Places.Add("ROME");
        Places.Add("PARIS");
        Places.Add("CALIFORNIA");
        Places.Add("LONDON");
        Places.Add("NEW DELHI");
        Places.Add("ZURICH");
        Places.Add("NAIROBI");
        Console.Clear();

        IEnumerable<string> QueryResult = from data in Places orderby data.Length ascending select data;

        System.Console.WriteLine("Resuts: ");
        for(int i=0; i<QueryResult.Count();i++)
        {
            System.Console.WriteLine(QueryResult.ElementAt(i));
        }
    }
}