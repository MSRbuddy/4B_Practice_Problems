namespace FrequencyOfElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] fr = new int[10];
            int n, i, j, count;


            Console.Write("\nCount the frequency of each element of an array:\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                fr[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        fr[j] = 0;
                    }
                }

                if (fr[i] != 0)
                {
                    fr[i] = count;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr[i], fr[i]);
                }
            }
        }
    }
}