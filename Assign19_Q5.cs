/*5. Accept N numbers from user and display summation 
of digits of each number.
Input : N : 6

Elements :8225 665 3 76 953 858

Output : 17 17 3 13 17 21
*/


using System;

class MyArray
{
	public void Digits(int []Arr)
	{
		Console.WriteLine("3 Digits Elements are : ");
		int no = 0,iSum = 0,iDigit = 0;
		for(int i=0;i<Arr.Length;i++)
		{
			no = Arr[i];
			iSum = 0;
			while(no!=0)
			{
				iDigit = no % 10;
				iSum = iSum + iDigit;
				no = no / 10;
			}
			
			Console.Write(iSum+"  ");
		}
		Console.WriteLine();
	}
}

namespace Assign19_Q4
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
			mobj.Digits(Arr);
		}
	}
}