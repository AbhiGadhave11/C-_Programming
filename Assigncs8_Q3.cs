/*3. Write a program which accept range from user 
    and return addition of all numbers in between 
   that range. 
(Range should contains positive numbers only)
Input : 23 30
Output : 212
Input : 10 18
Output : 126
Input : -10 2
Output : Invalid range
Input : 90 18
Output : Invalid range
*/

using System;

namespace Assigncs8_Q1
{
	class Program
	{
		public static int Range(int iStart,int iEnd)
		{
			int iSum=0;
			if((iStart > iEnd)||(iEnd<0)||(iStart<0))
			{
				
				return -1;
			}
			int i=0;
			for(i=iStart;i<=iEnd;i++)
			{
				iSum = iSum + i;
			}
			return iSum;
		} 
		public static void Main(String[] Arg)
		{
			int iValue1=0,iValue2=0,iRet=0;
			Console.WriteLine("Enter First Number");
			iValue1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Last Number");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			iRet = Range(iValue1,iValue2);
			if(iRet==-1)
			{
				Console.WriteLine("Invalid Range");
			}
			else 
			{
			  Console.WriteLine("Addition is "+iRet);
		    }
		}
	}
}