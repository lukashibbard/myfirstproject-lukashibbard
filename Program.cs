// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
Console.WriteLine ("what is your first and last name");
string name = Console.ReadLine ()+ "";
// line 4 and 5 get the users name and 7 pastes it greeting them
Console.WriteLine ($"nice to meet you {name}!");
Console.WriteLine("can you give me 3 numbers one at a time");
Console.WriteLine("number 1:");
string blank = " ";
string xstr = Console.ReadLine() + " ";
int x = Convert.ToInt32(xstr);
Console.WriteLine("number 2:");
string ystr = Console.ReadLine()+ "";
int y = Convert.ToInt32(ystr);
Console.WriteLine("number 3:");
string zstr = Console.ReadLine() + "";
int z = Convert.ToInt32(zstr);
// lines 11 through 18 collect the three numbers from the user
int v0 = x + y + z;
Console.WriteLine (v0);
int v1 = y - x;
Console.WriteLine (v1);
int v2 = x * z;
Console.WriteLine (v2);
int v3 = v0 / y;
Console.WriteLine (v3);
int v4 = x % v1;
Console.WriteLine (v4);
// lines 20 through 29 send the different var through a seri
