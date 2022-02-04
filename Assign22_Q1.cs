/*1.Write a program which accept string from user 
and count number of capital characters.

Input : “Marvellous Multi OS”

Output : 4
*/

using System;

class MyArray
{
	public int ConvertCapital(String str)
	{
		char []Arr = str.ToCharArray();
		int iCnt = 0;

		foreach(char ch in Arr)
		{
			if(ch>='A' && ch<='Z')
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}

namespace Assign22_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = null;

			str = Console.ReadLine();

			

			MyArray mobj = new MyArray();

			int iRet = mobj.ConvertCapital(str);
			Console.WriteLine("Count of Capital Letter is : "+iRet);
		}
	}
}
