using System.Linq;


namespace _11_LinqQueries;

class Program 
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        IEnumerable<Student> QueryResult =  student.AllStudentsLists().Where(temp => temp.Gender == "Male");

        System.Console.WriteLine();
        for(int i = 0; i<QueryResult.Count(); i++)
        {   
            System.Console.WriteLine($"StudentName: {QueryResult.ElementAt(i).StudentName}");
            System.Console.WriteLine($"StudentID: {QueryResult.ElementAt(i).StudentID}");
            System.Console.WriteLine($"Gender: {QueryResult.ElementAt(i).Gender}");

            System.Console.WriteLine();
        }
    }
}