/*5. Write a program which accept string from user and 
copy that characters of that string into another string 
by toggling the case.

Input : “Marvellous Python 2”

Output : “mARVELLOUS pYTHON 2”
*/

using System;

class MyArray
{
	public String Toggle(String str)
	{
		char []Arr = str.ToCharArray();
		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i]>='A' && Arr[i]<'Z')
			{
				Arr[i] = char.ToLower(Arr[i]);
			}
			else if(Arr[i]>='a' && Arr[i]<='z')
			{
				Arr[i] = char.ToUpper(Arr[i]);
			}
		}
		string str1 = new String(Arr);
		return str1;
	}
}

namespace Assign26_Q5
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String : ");
			String str = Console.ReadLine();

			MyArray mobj = new MyArray();
			String str1 =mobj.Toggle(str);

			Console.WriteLine("Updated String is : "+str1);
		}
	}
}
