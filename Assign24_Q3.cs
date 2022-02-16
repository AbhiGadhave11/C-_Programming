/*3.Write a program which accept string from user and 
accept one character. Return index of first occurrence 
of that character.

Input : “Marvellous Multi OS”
M
Output : 0

Input : “Marvellous Multi OS”
W
Output : -1

Input : “Marvellous Multi OS”
e
Output : 4
*/

using System;

class Myclass
{
	public int ChkIndex(String str,char ch)
	{
		char []Arr = str.ToCharArray();
		int i=0;
		for(i=0;i<Arr.Length;i++)
		{
			if(Arr[i] == ch)
			{
				break;
			}
		}
		if(i == Arr.Length)
		{
			return -1;
		}
		else
		{
			return i;
		}
	}
}


namespace Assign24_Q3
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();
			Console.WriteLine("Enter the Character");
			char ch = Console.ReadLine()[0];
			Myclass mobj = new Myclass();
			int iCnt = mobj.ChkIndex(str,ch);
			Console.WriteLine("Index is : "+iCnt);


		}
	}
}