/*4. Accept number from user and display below pattern.
Input : 4
Output : # 1 * # 2 * # 3 * # 4 *
*/

using System;

class Marvellous
{
	public void Pattern(int no)
	{
		for(int i=1;i<=no;i++)
		{
			Console.Write("# "+i+" * ");
		}
		Console.WriteLine();
	}
}
namespace Assign9_Q4
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int no = 0;
			Console.WriteLine("Enter the Number");
			no = Convert.ToInt32(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			mobj.Pattern(no);
		}
	}
}