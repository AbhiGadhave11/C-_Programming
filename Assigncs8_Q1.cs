/*1.Write a program which accept range from user and 
display all numbers in between that range.
Input : 23 35
Output : 23 24 25 26 27 28 29 30 31 32 33 34 35
Input : 10 18
Output : 10 11 12 13 14 15 16 17 18
Input : 10 10
Output : 10
Input : -10 2
Output : -10 -9 -8 -7 -6 -5 -4 -3 -2 -1 0 1 2
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
			for(i=iStart;i<=iEnd;i++)
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