/*4.Write a program which accept number from user 
and return multiplication of all digits.
Input : 2395
Output : 270
Input : 1018
Output : 8
Input : 9440
Output : 144
Input : 922432
Output : 864
*/

using System;

class Marvellous
{
	public  int  Display(int iNo)
	{
	   int iDigit = 0,iMulti=1;
	   if(iNo<0)
	   {
	   	iNo = -iNo;
	   }
	   while(iNo>0)
	   {
	   	iDigit = iNo % 10;
	   	if(iDigit == 0)
	   	{
	   		iNo = iNo / 10;
	   		continue;
	   	}
	    iMulti = iMulti * iDigit;
       iNo = iNo / 10;
       }
      return iMulti;
	}
}

namespace Assigncs6_Q4
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

           Console.WriteLine("Multiplication is : "+iRet);
		 }
	}
}