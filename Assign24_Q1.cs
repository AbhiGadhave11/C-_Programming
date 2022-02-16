/*1.Write a program which accept string from user and 
accept one character. Check whether that character 
is present in string or not.

Input : “Marvellous Multi OS”

e

Output : TRUE

Input : “Marvellous Multi OS”

W

Output : FALSE
*/

using System;

class MyClass
{
	public bool ChkCharacter(String str,char ch)
	{
		char []Arr = str.ToCharArray();
		bool flag = false;
		foreach (char cha in Arr)
		{
			if(cha == ch)
			{
				flag = true;
				break;
			}
		}
		return flag;
	}
}
namespace Assign24_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Console.WriteLine("Enter the Character");
			char ch = Console.ReadLine()[0];

			MyClass mobj = new MyClass(); 
			bool bRet = mobj.ChkCharacter(str,ch);
			if(bRet == true)
			{
				Console.WriteLine("Character is Present in given String");
			}
			else
			{
				Console.WriteLine("Character is not Present in given String");
			}

		}
	}
}