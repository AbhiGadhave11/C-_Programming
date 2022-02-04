/*3. Write a program which accept string from user 
and return difference between frequency of small 
characters and frequency of capital characters.

Input : “MarvellouS”

Output : 6 (8-2)
*/


using System;

class MyArray
{
	public int ConvertCapital(String str)
	{
		char []Arr = str.ToCharArray();
		int iCnt = 0,iCnt1=0;

		foreach(char ch in Arr)
		{
			if(ch>='a' && ch<='z')
			{
				iCnt++;
			}
			if(ch>='A' && ch<='Z')
			{
				iCnt1++;
			}
		}
		return iCnt-iCnt1;
	}
}

namespace Assign22_Q3
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
			Console.WriteLine("Difference of Small & Capital Letter is : "+iRet);
		}
	}
}
