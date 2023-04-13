namespace Matrix
{
    internal class Program
    {
        public void SumOfMatrix()
        {
            int sum = 0, row, col;
            Console.WriteLine("How many rows you want in matrix: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns you want in matrix: ");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix=new int[row, col];

            for(int i=0;i<row;i++)
            {
                for (int j=0;j<col;j++)
                {
                    Console.WriteLine("Enter elements of matrix: ");
                    matrix[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < row; i++)
            {
                sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum = sum + matrix[i, j];
                }
                Console.WriteLine("Sum of row[{0}] : {1}", (i + 1), sum);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SumOfMatrix();
        }
    }
}