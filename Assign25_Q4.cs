/*4. Write a program which accept string from user 
and copy small characters of that string into 
another string.

Input : “Marvellous multi OS”

Output : “arvellous multi”
*/

using System;

class Myclass
{
	public String StrCpyX(String str)
	{
		char []Arr = str.ToCharArray();
		
		String newStr = "";
		for(int i=0;i<Arr.Length;i++)
		{
			if((Arr[i]>='a' && Arr[i]<='z') || Arr[i]==' ')
				newStr = newStr + Arr[i];
		}
		return newStr;
	}
}
namespace Assign25_Q4
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();
			
			Myclass mobj = new Myclass();
			String newStr = mobj.StrCpyX(str);

			Console.WriteLine("Updated String is : "+newStr);
		}
	}
}
