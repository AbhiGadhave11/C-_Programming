/*5. Write a program which accept string from user and count number of white spaces

Input : “MarvellouS”

Output : 0

Input : “MarvellouS Infosystems”

Output : 1

Input : “MarvellouS Infosystems”

Output : 5
*/

using System;

class MyArray
{
	public int ConvertSmall(String str)
	{
		char []Arr = str.ToCharArray();

		int iCnt = 0;

		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i]==' ')
			{
				iCnt++;
			}
			
			
			
		}
		return iCnt;
	}
}

namespace Assign23_Q5
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = Console.ReadLine();

			MyArray mobj = new MyArray();
			int iRet = mobj.ConvertSmall(str);
			Console.WriteLine("White Spaces are : "+iRet);
		}
	}
}
