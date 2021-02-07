using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give a string and the programm converts it to a "triange"

            Console.WriteLine("Enter any string and press enter: ");
            string text = Console.ReadLine();

            if (text.Length % 2 == 0)
            {
                text += " ";
            }

            int position = text.Length / 2;
            int rows = text.Length / 2 + 1;
            int amount = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < position; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(text.Substring(position, amount));
                position--;
                amount += 2;
            }
        }
    }
}
