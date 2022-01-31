/*3. Write a program which accept distance in 
kilometre and convert it into meter.
(1 kilometre = 1000 Meter)
Input : 5
Output : 5000
Input : 12
Output : 12000
*/

using System;

namespace Assigncs7_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
            int iValue = 0,iAns=0;
            Console.WriteLine("Enter number in kilometre");
            iValue = Convert.ToInt32(Console.ReadLine());
            iAns = iValue *1000;
            Console.WriteLine("Number in Meter is : "+iAns);
		}
	}
}