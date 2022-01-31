/*5.Write a program which accept number from user 
and return difference between summation of all 
its factors and non factors.
 
Input : 12
Output : -34 (16 - 50)
Input : 10
Output : -29 (8 - 37)
*/

using System;

class Marvellous
{
	public  int  Display(int iNo)
	{
		 int i=0,iSum=0,fSum=0,Ans=0;
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
			else
			{
				fSum = fSum + i;
			}
		}
		Ans = fSum - iSum;
		return Ans;		
	}
}

namespace Assigncs4_Q5
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