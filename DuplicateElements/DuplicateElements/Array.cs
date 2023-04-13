namespace DuplicateElements
{
    internal class Array
    {
        public void ArrayInfo()
        {
            int[] arr=new int[10];
            int i, j, count = 0;
            Console.WriteLine("Elements");
            for(i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter Array Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elememnts in Array: ");
            for(i=0;i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //To find duplicate elements
            for(i=0;i<arr.Length;i++)
            {
                for(j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The no.of duplicate elements in Array : {0}", count);
        }
    }
}
