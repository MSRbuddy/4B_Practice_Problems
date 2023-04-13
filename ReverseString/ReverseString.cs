namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Reverse a String program in C#*****");
            string str, revstr;
            str = "Meghana";
            revstr = " ";
            int length;
            Console.WriteLine("Given string is : {0}", str);
            length = str.Length - 1;
            while(length >= 0)
            {
                revstr = revstr + str[length];
                length--;
            }
            Console.WriteLine("Reversed string is : {0}", revstr);
        }
    }
}