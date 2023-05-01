using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given an integer x, return true if x is a palindrome, and false otherwise.

//Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.
//Example 2:

//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
//Example 3:

//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(123);
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int reversed = 0;
            int original = x;
            while (x != 0)
            { //123
                int digit = x % 10; //3 
                x /= 10;//12            
                reversed = reversed * 10 + digit; //3,3*10 = 30 +2 =32             
            }
            Console.WriteLine(reversed);
            Console.ReadLine();
            return reversed == original;

        }
    }
}


