/*5. Accept number from user and check whether 
number is even or odd.
*/

using System;

class Marvellous
{
	public bool Display(int iNo)
	{
		
		if(iNo<0)
		{
			iNo = -iNo;
		}
		if(iNo % 2 == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

namespace Assigncs2_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           bool bRet = false;
		   Console.WriteLine("Enter Number");
		   iValue = Convert.ToInt32(Console.ReadLine());
          
           if(iValue == 0)
          {
          	Console.WriteLine("Number is neither Even nor odd");
          	System.Environment.Exit(0);
          }

		   Marvellous mobj = new Marvellous();
		   bRet = mobj.Display(iValue);

		   if(bRet==true)
		   {
		   	Console.WriteLine("Number is Even");
		   }
		   else
		   {
		   	Console.WriteLine("Number is odd");
		   }

		   
	    }
	}
}