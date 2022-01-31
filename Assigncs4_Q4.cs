/*4.Write a program which accept number from user
 and return summation of all its non factors.
Input : 12
Output : 50
Input : 10
Output : 37
*/

using System;


class Marvellous
{
	public  int  Display(int iNo)
	{
		 int i=0,iSum=0;
		 if(iNo < 0)
		 {
		 	iNo = -iNo;
		 }
		for(i=1;i<iNo;i++)
		{
			if(iNo%i!=0)
			{
				iSum = iSum + i;
			}
		}
		return iSum;
		
	}
}

namespace Assigncs4_Q4
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
		   int iRet = 0;
           
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		    iRet = mobj.Display(iValue);

		    Console.WriteLine("Result is : "+iRet);
		}
	}
}