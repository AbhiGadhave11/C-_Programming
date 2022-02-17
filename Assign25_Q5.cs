/*5. Write a program which 2 strings from user and concat 
second string after first string. (Implement strcat() 
	function).

Input : “Marvellous Infosystems”

“Logic Building”

Output : “Marvellous Infosystems Logic Building”
*/

using System;

class MyClass
{
	public String strcatX(String str1,String str2)
	{
		String newstr = str1 + " " + str2;
		return newstr;
	}
} 

namespace Assign25_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			Console.WriteLine("Enter First String");
			String str1 = Console.ReadLine();
			Console.WriteLine("Enter Second String");
			String str2 = Console.ReadLine();

			MyClass mobj = new MyClass();
			String newstr = mobj.strcatX(str1,str2);
			Console.WriteLine("Updated String is : "+newstr);
		}
	}
}
