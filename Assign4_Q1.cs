/*1.Write a program which accept number from user 
and display its multiplication of factors.
Input : 12
Output : 144 (1 * 2 * 3 * 4 * 6)
Input : 13
Output : 1 (1)
Input : 10
Output : 10 (1 * 2 * 5)
*/

using System;


class Marvellous
{
	public  long  Display(int iNo)
	{
		 long  iMulti = 1;
		 int i=0;
		for(i=1;i<iNo;i++)
		{
			if(iNo%i==0)
			{
				iMulti = iMulti * i;
			}
		}
		return iMulti;
	}
}

namespace Assigncs3_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           long  iRet = 0;
		   
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		   iRet = mobj.Display(iValue);

		   Console.WriteLine("Result is : "+iRet);

		}
	}
}
