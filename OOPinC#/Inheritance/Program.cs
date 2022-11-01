namespace Inheritance;

class Program 
{
    public static void Main(string[] args)
    {
        A obj = new B();

        obj.show();
        obj.display();
       // obj.check(true);
        obj.check(true, 18);
    }
}