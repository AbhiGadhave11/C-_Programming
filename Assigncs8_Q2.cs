/*2. Write a program which accept range from user 
and display all even numbers in between that range.

Input : 23 35
Output : 24 26 28 30 32 34
Input : 10 18
Output : 10 12 14 16 18
Input : 10 10
Output : 10
Input : -10 2
Output : -10 -8 -6 -4 -2 0 2
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
				if(i%2==0)
				{
				   Console.WriteLine(i);
			    }
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