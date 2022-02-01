/*1. Accept N numbers from user and return difference 
between summation of even elements and summation 
of odd elements.
Input : N : 6

Elements :85 66 3 80 93 88

Output : 53 (234 - 181)
*/

using System;

class Marvellous
{
	public int ArrayX(int []Arr,int n)
	{
		int i=0,iSum1=0,iSum2=0;
		for(i=0;i<Arr.Length;i++)
		{
			if(Arr[i]%2==0)
			{
				iSum1 = iSum1 + Arr[i];
			}
			else
			{
				iSum2 = iSum2 + Arr[i];
			}
		}
		return (iSum1 - iSum2);
	}
}
namespace Assign16_Q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int []Arr;
			int no=0;
			Console.WriteLine("Enter the Number of Elements");
			no = Convert.ToInt32(Console.ReadLine());
			Arr = new int[no];

			for(int i=0;i < no;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Marvellous mobj = new Marvellous();
			int iRet = mobj.ArrayX(Arr,no);
			Console.WriteLine("Difference of Sum of odd and even Elements is : "+iRet);
		}
	}
}