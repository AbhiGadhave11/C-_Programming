/*2.Write a program which accept string from user 
and convert it into upper case.

Input : “Marvellous Multi OS”

Output : MARVELLOUS MULTI OS
*/

using System;

class MyArray
{
	public void ConvertSmall(String str)
	{
		char []Arr = str.ToCharArray();

		Console.Write("Updated String is : ");

		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i]>='a' && Arr[i]<='z')
			{
				Arr[i] = char.ToUpper(Arr[i]);
			}
			Console.Write(Arr[i]);
		}
		Console.WriteLine();
	}
}

namespace Assign23_Q2
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = Console.ReadLine();

			MyArray mobj = new MyArray();
			mobj.ConvertSmall(str);
		}
	}
}
