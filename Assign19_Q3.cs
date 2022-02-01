/*3. Accept N numbers from user and return the 
difference between largest and smallest number.
Input : N : 6

Elements :85 66 3 66 93 88

Output : 90 (93 -3)
*/

using System;

class MyArray
{
	public int Difference(int []Arr)
	{
		int iSmall = Arr[0];
		int iBig = Arr[0];
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i]>iBig)
			{
				iBig = Arr[i];
			}
			if(Arr[i]<iSmall)
			{
				iSmall = Arr[i];
			}
		}
		return iBig-iSmall;
	}
}

namespace Assign19_Q3
{
	class Program
	{
		public static void Main(String []Arg)
		{
			int size = 0;
			Console.WriteLine("Enter the Size of an Array");
			size = Convert.ToInt32(Console.ReadLine());
			int []Arr = new int[size];

			Console.WriteLine("Enter the Elements"); 
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			MyArray mobj = new MyArray();
			int iRet = mobj.Difference(Arr);
			Console.WriteLine("Difference of Maximum and Minimum Element is : "+iRet);
		}
	}
}