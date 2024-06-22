namespace StringEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string znak = "ż";
            if(znak.Equals("z", StringComparison.InvariantCulture))
            {
                Console.WriteLine("Rowne");
            }
            else
            {
                Console.WriteLine("Nie rowne");
            }

            char[] array = new char[10];
            Console.WriteLine(array[0]);
        }
    }
}
