/*2. Write a program which accept string from user 
and count number of small characters.

Input : “Marvellous”

Output : 9
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
			if(ch>='a' && ch<='z')
			{
				iCnt++;
			}
		}
		return iCnt;
	}
}

namespace Assign22_Q2
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
			Console.WriteLine("Count of Small Letter is : "+iRet);
		}
	}
}
