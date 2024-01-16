namespace OperatorsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {

            int favNumber = 8;

            Console.WriteLine("Please guess my favorite number: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Sorry, too low.");

            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Sorry, too high.");

            }
            else
            {
                Console.WriteLine("Sorry, too low.");

            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Math is cool.");
                    break;

                case "english":
                    Console.WriteLine("English is ok");
                    break;

                case "pe":
                case "gym":
                    Console.WriteLine("I love running");
                    break;
                default:
                    Console.WriteLine($"Well thats interesting ");
                    break;

            }
        }
    }
}

