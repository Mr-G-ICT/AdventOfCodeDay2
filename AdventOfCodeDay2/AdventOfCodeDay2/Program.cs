using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intcode = { 1, 12, 2, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 13, 19, 2, 9, 19, 23, 1, 23, 6, 27, 1, 13, 27, 31, 1, 31, 10, 35, 1, 9, 35, 39, 1, 39, 9, 43, 2, 6, 43, 47, 1, 47, 5, 51, 2, 10, 51, 55, 1, 6, 55, 59, 2, 13, 59, 63, 2, 13, 63, 67, 1, 6, 67, 71, 1, 71, 5, 75, 2, 75, 6, 79, 1, 5, 79, 83, 1, 83, 6, 87, 2, 10, 87, 91, 1, 9, 91, 95, 1, 6, 95, 99, 1, 99, 6, 103, 2, 103, 9, 107, 2, 107, 10, 111, 1, 5, 111, 115, 1, 115, 6, 119, 2, 6, 119, 123, 1, 10, 123, 127, 1, 127, 5, 131, 1, 131, 2, 135, 1, 135, 5, 0, 99, 2, 0, 14, 0 };
            int opcode = 0;
            int ans = 0;
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            int position = 0;

            while (count < intcode.Length)
            {
                opcode = intcode[count];
                

                if (opcode == 1)
                {
                    num1 = intcode[count + 1];
                    num2 = intcode[count + 2];
                    position = intcode[count + 3];
                    ans = intcode[num1] + intcode[num2];
                    intcode[position] = ans;

                                   }
                else if (opcode == 2)
                {
                    num1 = intcode[count + 1];
                    num2 = intcode[count + 2];
                    position = intcode[count + 3];
                    ans = intcode[num1] * intcode[num2];
                    intcode[position] = ans;
                }
                else if (opcode == 99)
                { 
                    Console.WriteLine("end Prog");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("something went wrong");
                }
                count = count + 4;
            }
            count = 0;
            while (count < intcode.Length)
            {
                Console.WriteLine(intcode[count]);
                count = count + 1;
            }
            Console.ReadLine();
            }
        }
    }

