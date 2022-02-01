/*1. Accept N numbers from user and return the largest 
number.
Input : N : 6

Elements :85 66 3 66 93 88

Output : 93
*/
using System;

class MyArray
{
	public int Maximum(int []Arr)
	{
		int iBig = Arr[0];
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i] > iBig)
			{
				 iBig = Arr[i];
			} 
		}
		return iBig;
	} 
}

namespace Assign19_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			int size = 0;
			Console.WriteLine("Enter the Size of an Array");
			size = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Size is : " + size);

			int []Arr;
			Arr = new int[size];
			Console.WriteLine("Enter the Elements");
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			
			MyArray mobj = new MyArray();
			int iRet = mobj.Maximum(Arr);
			Console.WriteLine("Maximum Element in the Given Array is : "+iRet);
		}
	}
}