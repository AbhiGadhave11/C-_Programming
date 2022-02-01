/*1. Accept N numbers from user and return frequency 
of even numbers.
Input : N : 6

Elements :85 66 3 80 93 88

Output : 3
*/

using System;

class MyArray
{
	public int Even(int[] Arr)
	{
		int iCnt = 0;
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i] % 2 == 0)
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}

namespace Assign17_q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int []Arr;
			int n = 0;
			Console.WriteLine("Enter Number of Elements that we want to Enter in the array");
			n = Convert.ToInt32(Console.ReadLine());
			Arr = new int[n];

			for(int i=0;i<n;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			MyArray mobj = new MyArray();
			int iRet = mobj.Even(Arr);
			Console.WriteLine("Number of Even Numbers in the list is : "+iRet);
		}
	}
} 