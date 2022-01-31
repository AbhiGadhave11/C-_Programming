/*3.Write a program which accept number from user
 and display all its non factors.
Input : 12
Output : 5 7 8 9 10 11
Input : 13
Output : 2 3 4 5 6 7 8 9 10 11 12
Input : 10
Output : 3 4 6 7 8 9
*/

using System;


class Marvellous
{
	public  void  Display(int iNo)
	{
		 int i=0;
		for(i=1;i<iNo;i++)
		{
			if(iNo%i!=0)
			{
				Console.WriteLine(i);
			}
		}
		
	}
}

namespace Assigncs4_Q3
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