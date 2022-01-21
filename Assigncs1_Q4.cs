//4. Accept one number and check whether 
//is divisible by 5 or not.

using System;

class Marvellous
{
	public bool Display(int iNo)
	{
		if(iNo < 0)
		{
			iNo = -iNo;
		}
        if(iNo % 5 == 0)
        {
        	return true;
        }
        else
        {
        	return false;
        }
	}
}

namespace Assigncs1_Q4
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           bool bRet = false;
		   Console.WriteLine("Enter Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

		   Marvellous mobj = new Marvellous();
		   bRet = mobj.Display(iValue);

		   if(bRet==true)
		   {
		   	 Console.WriteLine("Number is divisible by 5");
		   }
		   else
		   {
		   	  Console.WriteLine("Number is not divisible by 5");
		   }
	    }
	}
}