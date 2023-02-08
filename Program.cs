using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    internal class Program
    {
        static int iteractiveFactorial(int N)
        { // Iterative Function Using Loop
            int Fact = 1;
            while (N > 1)
            {
                Console.Write("{0} * ", N);
                //cout << N << " * ";
                Fact *= N--; // *= means Fact = Fact * N--;, A *=B, A= A*B
            }
            Console.Write("{0} ", N);
            //cout << N;
            return Fact;
        }

        static int recursiveFactorial(int N)  //not all code path return a value - error
        { // Recursive Function
            if (N <= 1)
            {
                Console.Write("1");
                return 1;
            }
            Console.Write("{0} * ", N);

            return N * recursiveFactorial(N - 1); //will output as 0

        }
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Enter a positive integer (maximum value 15): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 15); //if this is true -> repeat
            Console.WriteLine("\n");
            //Console.WriteLine("\nIterative Factorial {0} = " + iteractiveFactorial(N).ToString());
            Console.WriteLine("\nIterative Factorial  " + N+ " = " + iteractiveFactorial(N).ToString());

            Console.WriteLine("\n");
            Console.WriteLine("\nRecursive Factorial " + N + " = " + recursiveFactorial(N).ToString());
            Console.ReadKey();
        }
    }
}