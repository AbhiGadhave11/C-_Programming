/*5.Write a program which accept accept range from 
  user and display all numbers in between that
  range in reverse order.
Input : 23 35
Output : 35 34 33 32 31 30 29 28 27 26 25 24 23
Input : 10 18
Output : 18 17 16 15 14 13 12 11 10
Input : 10 10
Output : 10
Input : -10 2
Output : 2 1 0 -1 -2 -3 -4 -5 -6 -7 -8 -9 -10
Input : 90 18
Output : Invalid range
*/

using System;

namespace Assigncs8_Q1
{
	class Program
	{
		public static void Range(int iStart,int iEnd)
		{
			if(iStart > iEnd)
			{
				Console.WriteLine("Invalid Range");
				return;
			}
			int i=0;
			for(i=iEnd;i>=iStart;i--)
			{
				Console.WriteLine(i);
			}
		} 
		public static void Main(String[] Arg)
		{
			int iValue1=0,iValue2=0;
			Console.WriteLine("Enter First Number");
			iValue1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Last Number");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			Range(iValue1,iValue2);
		}
	}
}