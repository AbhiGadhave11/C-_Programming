/*2.Write a program which accept number from user 
and check whether it contains 0 in it or not.
Input : 2395
Output : There is no Zero
Input : 1018
Output : It Contains Zero
Input : 9000
Output : It Contains Zero
Input : 10687
Output : It Contains Zero
*/

using System;

class Marvellous
{
	public  bool  Display(int iNo)
	{
	   int iDigit = 0,iCnt=0;
	   if(iNo<0)
	   {
	   	iNo = -iNo;
	   }
	   while(iNo>0)
	   {
	   	iDigit = iNo % 10;
	   if(iDigit == 0)
	   {
	   	iCnt++;
	   	break;
	   }  

	   	iNo = iNo / 10;
       }
       if(iCnt==0)
       {
       	 return false;
       }		
       else
       {
       	return true;
       }
	}
}

namespace Assigncs1_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
		   bool bRet = false;
           
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		   bRet = mobj.Display(iValue);

		    if(bRet == true)
		    {
		    	Console.WriteLine("It Contains Zero");
		    }
		    else
		    {
		    	Console.WriteLine("There is no Zero");
		    }
		}
	}
}