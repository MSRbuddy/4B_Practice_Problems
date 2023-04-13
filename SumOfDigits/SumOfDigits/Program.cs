namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To find the sum of all digits of a given number");
            Console.WriteLine("----------------------------------------------\n");

            Console.WriteLine("Enter a number: ");
            int n, sum=0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                sum = sum + n%10;
                n = n/10;
            }
            Console.WriteLine("\nSum of all digits of the given number: " + sum);
        }
    }
}