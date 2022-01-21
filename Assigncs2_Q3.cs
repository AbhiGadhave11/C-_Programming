/*3. Accept one number from user if number is 
less than 10 then print “Hello” otherwise print
 “Demo”.*/

 using System;

class Marvellous
{
	public void Display(int iNo)
	{
		if(iNo<0)
		{
			iNo = -iNo;
		}
		if(iNo<10)
		{
			Console.WriteLine("Hello");
		}
		else
		{
			Console.WriteLine("Demo");
		}
	}
}

namespace Assigncs2_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           
		   Console.WriteLine("Enter Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

		   Marvellous mobj = new Marvellous();
		   mobj.Display(iValue);

		   
	    }
	}
}