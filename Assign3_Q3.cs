/*3. Write a program which accept number from user 
and print even factors of that number.
Input : 36
Output: 2 6 12 18
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
			if((iNo % i == 0)&&(i % 2 == 0))
			{
			  Console.WriteLine(i);
		    }
		}
	}
}

namespace Assigncs3_Q3
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
