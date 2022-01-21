//5. Accept one number from user and print that
//   number of * on screen.

using System;

class Marvellous
{
	public void Display(int iNo)
	{
		while(iNo>0)
		{
			Console.WriteLine("*");
			iNo--;
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