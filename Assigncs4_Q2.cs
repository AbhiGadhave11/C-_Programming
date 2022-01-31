/*2.Write a program which accept number from user 
and display its factors in decreasing order.
Input : 12
Output : 6 4 3 2 1

Input : 13
Output : 1
Input : 10
Output : 5 2 1
*/

using System;


class Marvellous
{
	public  void  Display(int iNo)
	{
		 int i=0;
		for(i=(iNo-1);i>=1;i--)
		{
			if(iNo%i==0)
			{
				Console.WriteLine(i);
			}
		}
		
	}
}

namespace Assigncs4_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		    mobj.Display(iValue);
		}
	}
}