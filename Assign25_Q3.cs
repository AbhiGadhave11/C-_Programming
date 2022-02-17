/*3. Write a program which accept string from user 
and copy capital characters of that string into 
another string.

Input : “Marvellous Multi OS”

Output : “MMOS”
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
			if(Arr[i]>='A' && Arr[i]<='Z')
				newStr = newStr + Arr[i];
		}
		return newStr;
	}
}
namespace Assign25_Q3
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
