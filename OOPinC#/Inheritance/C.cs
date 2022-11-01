
namespace Inheritance
{
    public class C : A
    {
        public override void display()
        {
            System.Console.WriteLine("Inside C display");
        }

        public override void check(bool access)
        {
            System.Console.WriteLine(access);
        }

         public override void check(bool access, int number)
        {
            System.Console.WriteLine($"{access}  {number}");
        }
    }
}