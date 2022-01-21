/*4. Accept two numbers from user and display 
first number in second number of times.
Input : 12 5
Output : 12 12 12 12 12

Input : -2 3
Output : -2 -2 -2
Input : 21 -3
Output : 21 21 21
Input : -2 0
Output :
*/

using System;

class Marvellous
{
	public void Display(int iNo1,int iNo2)
	{
		int i=0;
		if(iNo2 < 0)
		{
			iNo2 = -iNo2;
		}
		for(i=1;i<=iNo2;i++)
		{
			Console.WriteLine(iNo1);
		}
	}
}

namespace Assigncs2_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue1 = 0,iValue2 = 0;
           
		   Console.WriteLine("Enter First Number");
		   iValue1 = Convert.ToInt32(Console.ReadLine());

		   Console.WriteLine("Enter Second Number");
		   iValue2 = Convert.ToInt32(Console.ReadLine());


		   Marvellous mobj = new Marvellous();
		   mobj.Display(iValue1,iValue2);

		   
	    }
	}
}