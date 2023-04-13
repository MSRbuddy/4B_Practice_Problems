namespace UniqueElements
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int n, count = 0;
            int[] arr1 = new int[10];
            int i, j, k;
            Console.Write("\n\nPrint all unique elements of an array:\n");
            Console.Write("------------------------------------------\n");
            Console.Write("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Checking duplicate elements in the array 
            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                count = 0;
                // Check duplicate bifore the current position and
                // increase counter by 1 if found.
                for (j = 0; j < i - 1; j++)
                {
                    // Increment the counter when the seaarch value is duplicate.
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                    }
                }
                // Check duplicate after the current position and
                // increase counter by 1 if found.
                for (k = i + 1; k < n; k++)
                {
                    // Increment the counter when the seaarch value is duplicate
                    if (arr1[i] == arr1[k])
                    {
                        count++;
                    }
                    // Duplicate numbers next to each other
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }
                // Print the value of the current position of the array as unique value
                // when counter remain contains its initial value.
                if (count == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");
        }
    }
}