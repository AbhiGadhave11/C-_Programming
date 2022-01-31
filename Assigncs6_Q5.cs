/*5.Write a program which accept number from user 
    and return difference between summation of even
    digits and summation of odd digits.
Input : 2395
Output : -15 (2 - 17)
Input : 1018
Output : 6 (8 - 2)
Input : 8440
Output : 16 (16 - 0)
Input : 5733
Output : -18 (0 - 18)
*/

using System;

class Marvellous
{
	public  int  Display(int iNo)
	{
	   int iDigit = 0,iSum=0,fSum=0;
	   if(iNo<0)
	   {
	   	iNo = -iNo;
	   }
	   while(iNo>0)
	   {
	   	  iDigit = iNo % 10;
	      if(iDigit % 2 == 0)
	       {
	   	      iSum = iSum + iDigit;
	       }  

	       if(iDigit % 2 != 0)
	       {
	   	      fSum = fSum + iDigit;
	       }  
           iNo = iNo / 10;
       }
      return (iSum-fSum);
	}
}

namespace Assigncs1_Q5
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

           Console.WriteLine("Difference is : "+iRet);
		 }
	}
}