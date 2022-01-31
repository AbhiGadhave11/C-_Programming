/*4.Write a program which accept number from user
    and count frequency of 4 in it.
Input : 2395
Output : 0
Input : 1018
Output : 0
Input : 9440
Output : 2
Input : 922432
Output : 1
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
	   if(iDigit == 4)
	   {
	   	iCnt++;
	   }  
       iNo = iNo / 10;
       }
      return iCnt;
	}
}

namespace Assigncs1_Q3
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

           Console.WriteLine("Frequency of 4 is : "+iRet);
		 }
	}
}