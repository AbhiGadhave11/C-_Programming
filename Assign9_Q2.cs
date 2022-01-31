/*2. Accept number from user and display below pattern.
Input : 5
Output : 5 # 4 # 3 # 2 # 1 #
*/

using System;

class Marvellous
{
	public void Display(int no)
	{
		for(int i=5;i>=1;i--)
		{
			Console.Write(i+" ");
			Console.Write("# ");
		}
		Console.WriteLine();
	}
}

namespace Assign9_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int value = 0;
			Console.WriteLine("Enter Number");
			value = Convert.ToInt32(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			mobj.Display(value);
		}
	}
}