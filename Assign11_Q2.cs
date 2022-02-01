/*3. Accept number of rows and number of columns 
from user and display below pattern.

Input : iRow = 3 iCol = 5
Output : 
A A A A A
B B B B B
C C C C C
*/

using System;

class Marvellous
{
	public void Pattern(int iRow,int iCol)
	{
		int i=0,j=0;
		char ch = 'A';
		for(i=1;i<=iRow;i++)
		{
			for(j=1;j<=iCol;j++)
			{
				Console.Write(ch+" ");
			}
			ch++;
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
