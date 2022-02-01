/*5. Accept number of rows and number of columns 
from user and display below pattern.
Input : iRow = 4 iCol = 4

Output : 
1 2 3 4
1 * * 4
1 * * 4
1 2 3 4
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
				if((i==1&&j<=iCol)||(i==iRow&&j<=iCol)||(j==1&&i<=iRow)||(j==iCol&&i<=iRow))
				{
				  Console.Write(j+" ");
				}
				else
				{
					Console.Write("* ");
				}
			}
			
			Console.WriteLine();
		}
	}
}
namespace Assign12_Q1
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