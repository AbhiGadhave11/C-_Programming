/*1. Accept Character from user and check whether it 
is alphabet or not
(A-Z a-z).
Input : F
Output : TRUE
Input : &
Output : FALSE
*/

using System;


class MyArray
{
	public bool ChkAlphabet(char ch)
	{
		if((ch>='A' && ch<='Z')||(ch>='a' && ch<='z'))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

namespace Assign20_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the Character");
			char ch = '\0';
			ch = Convert.ToChar(Console.ReadLine());


			MyArray mobj = new MyArray();

			bool bRet = mobj.ChkAlphabet(ch);
			if(bRet == true)
			{
				Console.WriteLine("TRUE");
			}
			else
			{
				Console.WriteLine("FALSE");
			}
		}
	}
}
