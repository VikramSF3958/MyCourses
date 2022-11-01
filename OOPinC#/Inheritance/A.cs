
namespace Inheritance
{
    public abstract class A
    {
        public virtual void show()
        {
            System.Console.WriteLine("Inside Class A show");
        }

        public abstract void display();

        public abstract void check(bool access);
        public abstract void check(bool access, int number);
        
    }
}