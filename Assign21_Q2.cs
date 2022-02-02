/*3. Accept character from user. If it is capital 
then display all the characters from the input 
characters till Z. If input character is small then 
print all the characters in reverse order till a. 
In other cases return directly.
Input : Q
Output : Q R S T U V W X Y Z
Input : m
Output : m l k j i h g f e d c b a
Input : 8
Output :
*/

using System;

class MyArray
{
	public void Display(char ch)
	{
		if(ch>='A' && ch<='Z')
		{
			do
			{
				Console.Write(ch+" ");
				ch++;
			}while(ch!='[');


		}
		if(ch>='a' && ch<='z')
		{
			while(ch!='`')
			{
				Console.Write(ch+" ");
				ch--;
			}
		}
		Console.WriteLine();
	}
}
namespace Assign21_Q1
{
  class Program
  {
      public static void Main(String []Arg)
      {
          char ch = '\0';
          Console.WriteLine("Enter the Character");
          ch = Convert.ToChar(Console.ReadLine());
          MyArray mobj = new MyArray();

          mobj.Display(ch);
          
      }
  }
}
