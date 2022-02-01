/*3. Accept N numbers from user check whether that 
numbers contains 11 in it or not.
Input : N : 6

Elements :85 66 11 80 93 88

Output : 11 is present
Input : N : 6

Elements :85 66 3 80 93 88

Output : 11 is absent
*/

using System;

class MyArray
{
	public bool Display(int[] Arr)
	{
		int i = 0;
		for( i=0;i<Arr.Length;i++)
		{
			if(Arr[i] == 11)
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
			int size = 0;
			Console.WriteLine("Enter the size of an array");
			size = Convert.ToInt32(Console.ReadLine());
			Arr = new int[size];
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			MyArray mobj = new MyArray();
			bool bRet = mobj.Display(Arr);
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