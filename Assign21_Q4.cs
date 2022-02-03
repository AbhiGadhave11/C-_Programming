/*3. Accept character from user. If character is small display its
corresponding capital character, and if it small then display its
corresponding capital. In other cases display as it is.
Input : Q
Output : q
Input : m
Output : M
Input : 4
Output : 4
Input : %
Output : %
*/

using System;

class MyArray
{
	public char Display(char ch)
	{
		if(ch>='A' && ch<='Z')
		{
			ch = char.ToLower(ch);
			
		}
		else if(ch>='a' && ch<='z')
		{
			ch = char.ToUpper(ch);
		
		}
		return ch;
		
	}
}
namespace Assign21_Q3
{
  class Program
  {
      public static void Main(String []Arg)
      {
          char ch = '\0';
          Console.WriteLine("Enter the Character");
          ch = Convert.ToChar(Console.ReadLine());
          MyArray mobj = new MyArray();


          char cret = mobj.Display(ch);
          Console.WriteLine("Updated Letter : "+cret);
      }
  }
}
