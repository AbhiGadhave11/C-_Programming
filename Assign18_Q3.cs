/*3. Accept N numbers from user and accept one 
another number as NO , return index of last 
occurrence of that NO.

Input : N : 6
NO: 66
Elements :85 66 3 66 93 88

Output : 3
Input : N : 6
NO: 93
Elements :85 66 3 66 93 88

Output : 4
Input : N : 6
NO: 12
Elements :85 11 3 15 11 111

Output : -1
*/

using System;

class MyArray
{
	public int Display(int[] Arr,int no)
	{
		int i = 0;
		for( i=Arr.Length-1;i>=0;i--)
		{
			if(Arr[i] == no)
			{
				break;
			}
		}
		if(i==0)
		return -1;
		else
		return i;
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
			int bRet = mobj.Display(Arr,no);
			Console.WriteLine("Index is : "+bRet);
			
		}
	}
}