

namespace StarRectangle
{
    internal class Star
    {
        public void StarRectangle()
        {
            int length = 7, width = 7;
            for(int i=1; i<=width; i++)
            {
                for(int j = 1; j <= length; j++)
                {
                    if(i == 1 || i==width || j==1 || j==length)
                    {
                        Console.Write("*");
                    }                 
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
