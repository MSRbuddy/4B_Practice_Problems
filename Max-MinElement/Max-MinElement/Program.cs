namespace Max_MinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, max, min, n;

            Console.WriteLine("\nFind maximum and minimum element in an array : ");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\nEnter the number of elements to be sorted in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter {0} elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            max = arr[0];
            min = arr[0];

            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }


                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("\nMaximum element in the given Array is : {0}", max);
            Console.WriteLine("\nMinimum element in the given Array is : {0}", min);
        }
    }
}