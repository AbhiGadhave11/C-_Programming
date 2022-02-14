/*1.Write a program which accept string from user 
and convert it into lower case.

Input : “Marvellous Multi OS”

Output : marvellous multi os
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
			if(Arr[i]>='A' && Arr[i]<='Z')
			{
				Arr[i] = char.ToLower(Arr[i]);
			}
			Console.Write(Arr[i]);
		}
		Console.WriteLine();
	}
}

namespace Assign23_Q1
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
