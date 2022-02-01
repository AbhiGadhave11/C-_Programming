/*5. Accept N numbers from user and accept one another
 number as NO ,return frequency of NO form it.

Input : N : 6

NO: 66
Elements :85 66 3 66 93 88

Output : 2
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111

Output : 0
*/


using System;

class MyArray
{
	public int Display(int[] Arr,int no)
	{
		int i = 0,iCnt = 0;
		for( i=0;i<Arr.Length;i++)
		{
			if(Arr[i] == no)
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}

namespace Assign17_Q3
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int[] Arr;
			int size = 0,no = 0;
			Console.WriteLine("Enter the size of an array");
			size = Convert.ToInt32(Console.ReadLine());
			Arr = new int[size];
			Console.WriteLine("Enter the Elements");
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Enter Number");
			no = Convert.ToInt32(Console.ReadLine());

			MyArray mobj = new MyArray();
			int bRet  =0;
			 bRet = mobj.Display(Arr,no);
			Console.WriteLine("Frequency of 11 is : "+bRet);
			
		}
	}
}