namespace StarTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Print Stars in Triangle pattern!-----\n");
            int i, j;
            for(i = 1; i <= 8; i++)
            {
                for (j = i; j <= 8; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}