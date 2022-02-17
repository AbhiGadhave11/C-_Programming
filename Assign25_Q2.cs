/*2. Write a program which accept string from user 
and copy the contents of that string into another 
string. (Implement strncpy() function)

Input : “Marvellous Multi OS”
10
Output : “Marvellous
*/

using System;

class Myclass
{
	public String StrCpyX(String str,int no)
	{
		char []Arr = str.ToCharArray();
		if(no>str.Length)
		{
			no = str.Length;
		}
		String newStr = "";
		for(int i=0;i<no;i++)
		{
			newStr = newStr + Arr[i];
		}
		return newStr;
	}
}
namespace Assign25_Q2
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();
			Console.WriteLine("Enter the Number");
			int no = Convert.ToInt32(Console.ReadLine());

			Myclass mobj = new Myclass();
			String newStr = mobj.StrCpyX(str,no);

			Console.WriteLine("Updated String is : "+newStr);
		}
	}
}
