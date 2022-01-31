/*5. Accept number from user and display below pattern.
Input : 8
Output : 2 4 6 8 10 12 14 16
*/

using System;

class Marvellous
{
	public void Pattern(int no)
	{
		for(int i=1;i<=no;i++)
		{
			Console.Write(i*2+" ");
		}
		Console.WriteLine();
	}

}
namespace Assign9_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int value = 0;
			Console.WriteLine("Enter the number");
			value = Convert.ToInt32(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			mobj.Pattern(value);
		}
	}
}