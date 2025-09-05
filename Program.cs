using System.Reflection.Metadata.Ecma335;

namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number and I will give you the corresponding member of the Fibonacci sequence: ");
            
            int number=1;
            var input=Console.ReadLine();

            //Check if the input meets the requirements
            while (!int.TryParse(input, out number) || number<1)
            {
                Console.Clear();
                Console.Write("Please enter a NUMBER GREATER THAN 0: ");
                input = Console.ReadLine();
            }
            
            int answer = Fib(number); 
            
            Console.Clear();
            Console.WriteLine("Your number: " + number + "\nAnswer: " + answer+"\n");

            //List the members of the sequence
            foreach (int n in Sequence) 
            {
                if(n==answer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(n);
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
                }
                Console.Write(n+", ");
            }
        }
        
        //Febonacci Sequence list
        static List<int> Sequence = new List<int>() {0,1};
        
        public static int Fib(int n)
        {
            return Fib(n, 0, 1);
        }
        
        private static int Fib(int n, int previusNum, int currentNum)
        {
            if (n == 1)  return 0;

            int result = currentNum;
            
            int swap = previusNum + currentNum;
            previusNum = currentNum;
            currentNum = swap;
            --n;

            Sequence.Add(currentNum);

            if(n>=2) result = Fib(n, previusNum, currentNum);

            return result;
        }
    }
}
