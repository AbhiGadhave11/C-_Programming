/*4. Accept N numbers from user and display all such
 elements which are divisible by 3 and 5.
Input : N : 6

Elements :85 66 3 15 93 88
Output : 15
*/

using System;

class Marvellous
{
	public void ArrayX(int []Arr)
	{
		Console.WriteLine("Elements which are even and Divisible by 5 : ");
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i] % 5 == 0 && Arr[i]%3==0)
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