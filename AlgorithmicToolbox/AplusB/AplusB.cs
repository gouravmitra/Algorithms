using System;

namespace AlgorithmicToolBox
{
    class AplusB
    {
        static void Main(string[] args)
        {
            int a = Int32.MinValue;
            int b = Int32.MinValue;

            string inputLine = String.Empty;
            char delimiter = ' ';
            inputLine = Console.ReadLine();
            string[] inputs = inputLine.Split(delimiter);

            while (true)
            {
                if (inputs == null || inputs.Length < 2)
                {
                    Console.WriteLine("Invalid input. Try again!!");
                    inputLine = Console.ReadLine();
                    inputs = inputLine.Split(delimiter);
                }
                else
                {
                    if(Int32.TryParse(inputs[0], out a) && Int32.TryParse(inputs[1], out b))
                    {
                        int output = a + b;
                        Console.WriteLine(output);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
