using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaToInteger
{

//    Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    internal class Program
    {
        static void Main(string[] args)
        {
            RomaToInteger("MCMXCIV");
        }

        public static int RomaToInteger(string s)
        {
            int answer = 0;
            int num = 0;
            for (int x = s.Length - 1; x >= 0; x--)
            {
                switch (s[x])
                {
                    case 'I':
                        num = 1;
                        break;
                    case 'V':
                        num = 5;
                        break;
                    case 'X':
                        num = 10;
                        break;
                    case 'L':
                        num = 50;
                        break;
                    case 'C':
                        num = 100;
                        break;
                    case 'D':
                        num = 500;
                        break;
                    case 'M':
                        num = 1000;
                        break;
                      

                }
                if(4 * num < answer) //5*4 = 20 <0, 4*1 = 4 <5
                {
                    //answer = 5-1 = 4
                    answer -= num;
                }
                else //answer = 5
                {
                    answer += num;
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();

            return answer;
        }
    }
}
