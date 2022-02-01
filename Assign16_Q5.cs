/*5. Accept N numbers from user and display all such 
elements which are multiples of 11.
Input : N : 6

Elements :85 66 3 55 93 88

Output : 66 55 88
*/

using System;

class Marvellous
{
	public void ArrayX(int []Arr)
	{
		Console.WriteLine("Elements which are even and Divisible by 5 : ");
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i] % 11 == 0 )
			{
				Console.Write(Arr[i]+" ");
			}
		}
		Console.WriteLine();
	}
}
namespace Assign16_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int []Arr;
			int no = 0;
			Console.WriteLine("Enter Number of Elements");
			no = Convert.ToInt32(Console.ReadLine());
			Arr = new int[no];
			Console.WriteLine("Enter The Elements");
			for(int i=0;i<no;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Marvellous mobj = new Marvellous();
			mobj.ArrayX(Arr);
		}
	}
}