/*5. Accept number of rows and number of columns 
from user and display below pattern.

Input : iRow = 4 iCol = 4
Output : 
1 2 3 4
  2 3 4
    3 4
      4

*/

using System;

class Marvellous
{
	public void Pattern(int iRow,int iCol)
	{
		int i=0,j=0;
		for(i=1;i<=iRow;i++)
		{
			for(j=1;j<=iCol;j++)
			{
				if(j<=i-1)
				{
					Console.Write("  ");
				}
				else
				{
					Console.Write(j+" ");
				}
			}
			Console.WriteLine();
		}
	}
}
namespace Assign14_Q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int iValue1=0,iValue2=0;
			
			Console.WriteLine("Enter Number of Rows");
			iValue1 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Number of Columns");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			mobj.Pattern(iValue1,iValue2); 
		}
	}
}


