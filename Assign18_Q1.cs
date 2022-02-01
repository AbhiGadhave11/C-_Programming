/*1. Accept N numbers from user and accept one another
 number as NO , check whether NO is present or not.

Input : N : 6
NO: 66
Elements :85 66 3 66 93 88

Output : TRUE
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111

Output : FALSE
*/


using System;

class MyArray
{
	public bool Display(int[] Arr,int no)
	{
		int i = 0;
		for( i=0;i<Arr.Length;i++)
		{
			if(Arr[i] == no)
			{
				break;
			}
		}
		if(i == Arr.Length)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}

namespace Assign17_Q3
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int[] Arr;
			int size = 0,no=0;
			Console.WriteLine("Enter the size of an array");
			size = Convert.ToInt32(Console.ReadLine());
			Arr = new int[size];
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Enter Number");
			no = Convert.ToInt32(Console.ReadLine());

			MyArray mobj = new MyArray();
			bool bRet = mobj.Display(Arr,no);
			if(bRet == true)
			{
				Console.WriteLine("Element is there");
			}
			else
			{
				Console.WriteLine("There is no Element ");
			}
		}
	}
}