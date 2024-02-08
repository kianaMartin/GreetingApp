namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int totalnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("name: " + name + "\nTotal enrolled courses: " + totalnum + "\nPrice of my favorite book: " + price);
            Console.WriteLine("\npress any to exit...");
            Console.ReadKey();
        }
    }
}