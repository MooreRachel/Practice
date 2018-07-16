//100 doors in C# problem and solution from rosettacode.org
́́//http://rosettacode.org/wiki/100_doors#C.23
// see the code working at https://dotnetfiddle.net/LO3iKU

namespace ConsoleApplication1 
{
    using System;
    class Program 
    {
        static void Main(strings[] args)
        {
            bool[] doors = new bool[100];

            //Close all doors to start.
            for (int d = 0; d <100; d++) doors [d] = false;

            //For each pass..
            for (int p = 0; p < 100; p++) // number of passes
            {
                //for each door to toggle...
                for (int d = 0; d < 100; d++)// door number 
                {
                    if((d + 1) % (p + 1 ) == 0)
                    {
                        doors[d] = !doors[d];
                    }

                } 
            }

            //Output the results
            Console.WriteLine("Passes Completed!!! Here are the results: \r\n");
            for (int d = 0; d < 100; d++)
            {
                if (doors[d])
                {
                    Console.WriteLine(String.Format("Door#{0}: Open", d + 1));
                }
                else
                {
                    Console.WriteLine(String.Format("Door #{0}: Closed", d + 1));
                }
            }
            Console.Readline();
            }
        }
}    
