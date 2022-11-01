
namespace Inheritance
{
    public class B : A
    {   
        private int num = 18;
        public override  void show()
        {
            System.Console.WriteLine("Inside B show");
        }
        public override void display()
        {
            System.Console.WriteLine("Inside B display");
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