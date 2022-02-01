/*2. Accept number of rows and number of columns 
from user and display below pattern.
Input : iRow = 4 iCol = 4
Output : 
A B C D
a b c d
A B C D
a b c d
*/

using System;

class Marvellous
{
	public void Pattern(int iRow,int iCol)
	{
		char ch='A',ch1 = 'a';
		int i=0,j=0;
		for(i=1;i<=iRow;i++)
		{
			ch = 'A';
			ch1 = 'a';
			for(j=1;j<=iCol;j++)
			{
				if(i%2 == 0)
				{
					Console.Write(ch1+" ");
				}
				else
				{
					Console.Write(ch+" ");
				}
				ch++;
				ch1++;
			}
			Console.WriteLine();
		}
	}
}

namespace Assign11_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int iValue1 = 0,iValue2=0;
			Console.WriteLine("Enter Number of Rows");
			iValue1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Number of Columns");
			iValue2 = Convert.ToInt32(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			mobj.Pattern(iValue1,iValue2);
		}
	}
}
