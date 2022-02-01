/*5. Accept N numbers from user and return product 
of all odd elements.
Input : N : 6

Elements :15 66 3 70 10 88

Output : 45
Input : N : 6

Elements :44 66 72 70 10 88

Output : 0
*/

using System;

class MyArray
{
	public int Display(int[] Arr)
	{
		int i = 0,iMulti = 1;
		bool flag = false;
		for( i=Arr.Length-1;i>=0;i--)
		{
			if(Arr[i]%2!=0)
			{
				flag = true;
				iMulti = iMulti * Arr[i];
			}
		}
		if(flag == true)
		return iMulti;
		else
		return 0;
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
			int bRet = mobj.Display(Arr);
			Console.WriteLine("Multiplication of odd Number is : "+bRet);
			
		}
	}
}