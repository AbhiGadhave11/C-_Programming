/*4. Accept number of rows and number of columns 
from user and display below pattern.
Input : iRow = 4 iCol = 5
Output : 
4 4 4 4 4
3 3 3 3 3
2 2 2 2 2
1 1 1 1 1
*/


using System;

class Marvellous
{
	public void Pattern(int iRow,int iCol)
	{
		int i=0,j=0;
		
		for(i=iRow;i>=1;i--)
		{
			for(j=1;j<=iCol;j++)
			{
				Console.Write(i+" ");
			}
			
			Console.WriteLine();
		}
	}
}
namespace Assign11_Q3
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int iValue1=0,iValue2=0;
			Console.WriteLine("Enter number of Rows");
			iValue1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number of Columns");
			iValue2 = Convert.ToInt32(Console.ReadLine());
			Marvellous mobj = new Marvellous();
			mobj.Pattern(iValue1,iValue2); 
		}
	}
}
