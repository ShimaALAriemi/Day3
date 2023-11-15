namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Even NumberProgram

            Console.WriteLine("Enter a Number : ");
            String evenNum = Console.ReadLine();
            int numE = int.Parse(evenNum);
            String addOrEven = (numE % 2 == 0) ? "Your Number is Even\n" : "Your Number is Odd\n";
            Console.WriteLine(addOrEven);


            // Odd NumberProgram

            Console.WriteLine("Enter a Number : ");
            String oddNum = Console.ReadLine();
            int numO = int.Parse(oddNum);
            String evenOrOdd = (numO % 3 == 0) ? "Your Number is Odd\n" : "Your Number is Even\n";
            Console.WriteLine(evenOrOdd);


        }
    }
}