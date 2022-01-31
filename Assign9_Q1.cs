/*1. Accept number from user and display below 
     pattern.
Input : 5
Output : A B C D E
*/

using System;

class Marvellous
{
	public void Display(int no)
	{
		//String ch = new String("A");
		char ch = 'A';
		for(int i=0;i<no;i++)
		{
			Console.Write(ch+" ");
			ch++;
		}
		Console.WriteLine();
	}
}

namespace Assign9_Q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int no = 0;
			Console.WriteLine("Enter the Number");
		    no = Convert.ToInt32(Console.ReadLine());
			
			Marvellous mobj = new Marvellous();
			mobj.Display(no);
		}
	}
}