/*3.Write a program which accept number from user 
and return the count of digits in between 3 and 7.
Input : 2395
Output : 1
Input : 1018
Output : 0
Input : 4521
Output : 2
Input : 9922
Output : 0
*/

using System;

class Marvellous
{
	public  int  Display(int iNo)
	{
	   int iDigit = 0,iCnt=0;
	   if(iNo<0)
	   {
	   	iNo = -iNo;
	   }
	   while(iNo>0)
	   {
	   	iDigit = iNo % 10;
	   if(iDigit > 3 && iDigit < 6)
	   {
	   	iCnt++;
	   }  
       iNo = iNo / 10;
       }
      return iCnt;
	}
}

namespace Assigncs6_Q3
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

           Console.WriteLine("Count of in between 3 and 7 is : "+iRet);
		 }
	}
}