/* 3. Accept number of rows and number of columns 
from user and display below pattern.
Input : iRow = 3 iCol = 5
Output : 
5 4 3 2 1
5 4 3 2 1
5 4 3 2 1
*/

using System;

class Marvellous
{
	public void Pattern(int iRow,int iCol)
	{
		int i = 0,j=0;
		for(i=1;i<=iRow;i++)
		{
			for(j=iCol;j>=1;j--)
			{
				Console.Write(j+" ");
			}
			Console.WriteLine();
		}
	}
}

namespace Assign10_Q3
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