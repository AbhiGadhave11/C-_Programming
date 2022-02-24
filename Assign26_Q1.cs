/*1. Write a program which accept string from user and 
copy that characters of that string into another 
string in reverse order.

Input : “Marvellous Python”

Output : “nohtyP suollevraM”
*/

using System;

class Myclass
{
	public String ReverseX(String str)
	{
		char []Arr = str.ToCharArray();
		String newStr = "";
		for(int i=str.Length-1;i>=0;i--)
		{
			newStr = newStr + Arr[i];
		} 
		return newStr;
	}
}

namespace Assign26_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Myclass mobj = new Myclass();
			String newStr = mobj.ReverseX(str);
			Console.WriteLine("Reverse String : "+newStr);
		}
	}
}
