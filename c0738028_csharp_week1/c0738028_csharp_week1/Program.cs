using System;

namespace c0738028_csharp_week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int start = 314;
            int end = 102;
            Console.WriteLine("Sum of the numbers");
            for (int i= start; i> end; i-=6)//going down by 6
            {

               sum += i;
                //Console.WriteLine(" Now Number is" + i);
                //Console.WriteLine("Now sum is" +sum);
            }

            Console.WriteLine("The answer is " +sum);
            Console.ReadLine();
        }
      
    }
}
