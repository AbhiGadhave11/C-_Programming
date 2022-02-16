/*5. Write a program which accept string from user 
reverse that string in place.

Input : “abcd”

Output : “dcba”

Input : “abba”

Output : “abba”
*/

using System;

class Myclass
{
	public String Reverse(String str)
	{
		char []Arr = str.ToCharArray();
		int i=0;
		int no = Arr.Length-1;
		char temp = 'X';
		while(i < no)
		{
			temp = Arr[i];
			Arr[i] = Arr[no];
			Arr[no] = temp;
			no--;
			i++;
		}
		String strX = new String(Arr);
		return strX;
		
	}
}


namespace Assign24_Q5
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();
			
			Myclass mobj = new Myclass();
			String Sret  = mobj.Reverse(str);
			Console.WriteLine("Updated String : "+Sret);
			


		}
	}
}