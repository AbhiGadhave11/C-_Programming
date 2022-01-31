/*2. Write a program which accept number from user 
and print even factors of that number.
Input : 24
Output: 1 2 4 6 8 12
*/

using System;

class Marvellous
{
	public void Display(int iNo)
	{
		int i=0;
		if(iNo < 0)
		{
			iNo = -iNo;
		}
		for(i=1;i<=(iNo/2);i++)
		{
			if(iNo % i == 0)
			{
			  Console.WriteLine(i);
		    }
		}
	}
}

namespace Assigncs3_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
           
		   
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		   mobj.Display(iValue);

		}
	}
}
