/*2.Write a program which accept string from user and 
accept one character. Return frequency of that character.

Input : “Marvellous Multi OS”
M
Output : 2

Input : “Marvellous Multi OS”
W
Output : 0
*/
using System;

class Myclass
{
	public int CountChar(String str,char ch)
	{
		char []Arr = str.ToCharArray();
		int iCnt = 0;
		foreach (char cha in Arr)
		{
			if(cha == ch)
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}

namespace Assign24_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();
			Console.WriteLine("Enter tne Character ");
			char ch = Console.ReadLine()[0];

			Myclass mobj = new Myclass();
			int iCnt = 0;
			iCnt = mobj.CountChar(str,ch);

			Console.WriteLine("Count of Given Character in String is : "+iCnt);

		}
	}
}