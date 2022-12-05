
namespace _4_Array
{
    public class Operations
    {
        public void Sorting()
        {
            System.Console.WriteLine("Enter numbers to the array: ");
            int number = 0;

            int[] array = new int[5];

            for(int i =0; i<5; i++)
            {
                number = int.Parse(Console.ReadLine());

                array[i] = number;
            }



            for(int i=1; i<5; i++)
            {
                int key = array[i];

                for(int j = i - 1; j >= 0; j-- )
                {
                    if(array[j] > key)
                    {
                        int temp = 0;
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j + 1] = temp;
                    }
                }
            }

            for(int i=0; i<5; i++)
            {
                System.Console.Write($"{array[i]} ");
            }


        }
    
        public void  PrintOddEven()
        {
            System.Console.WriteLine("Enter numbers to the array: ");
            int number = 0;

            int[] array = new int[10];

            for(int i =0; i<10; i++)
            {
                number = int.Parse(Console.ReadLine());

                array[i] = number;
            }


            System.Console.Write("Odd Numbers: ");
            for(int i=0; i<10; i++)
            {
                if(array[i]%2==1)
                {
                    System.Console.Write($"{array[i]} ");
                }
            }

            System.Console.Write("Even Numbers: ");
            for(int i=0; i<10; i++)
            {
                if(array[i]%2==0)
                {
                    System.Console.Write($"{array[i]} ");
                }
            }


        }
    }
}