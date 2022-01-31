/*1.Write a program which accept one number from 
user and print that number of even numbers on screen.
Input : 7
Output: 2 4 6 8 10 12 14
*/

using System;

class Marvellous
{
	public void Display(int iNo2)
	{
		int i=0;
		if(iNo2 < 0)
		{
			iNo2 = -iNo2;
		}
		for(i=1;i<=(iNo2*2);i++)
		{
			if(i % 2 == 0)
			{
			  Console.WriteLine(i);
		    }
		}
	}
}

namespace Assigncs2_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue2 = 0;
           
		   
		   Console.WriteLine("Enter First Number");
		   iValue2 = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		   mobj.Display(iValue2);

		}
	}
}
