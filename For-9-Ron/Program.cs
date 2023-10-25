using System;

namespace For_9_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num1 = 0, num2 = 0, end = 0;
            long factorial = 1, sum = 0;

            // receiving first and second inputs
            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num2 = int.Parse(Console.ReadLine());

            // deciding which input is smaller to start from it
            if (num1 < num2)
            {
                i = num1;
                end = num2;
            }
            else
            {
                i = num2;
                end = num1;
            }

            // calculating factorial and sum in range of numbers
            for (; i <= end; i++)
            {
                factorial *= i;
                sum += i;
            }

            // printing final results to user
            Console.WriteLine($"The factorial in the range is: {factorial}\nThe sum of numbers in the range is: {sum}");
            Console.ReadLine();
        }
    }
}
