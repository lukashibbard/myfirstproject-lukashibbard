// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
Console.WriteLine ("what is your first and last name");
string name = Console.ReadLine ()+ "";
Console.WriteLine ($"nice to meet you {name}!");
Console.WriteLine("can you give me 3 numbers one at a time");
Label1:
Console.WriteLine("number 1:");
string blank = " ";
string xstr = Console.ReadLine() + " ";
if (xstr == blank)
{
    Console.WriteLine("please type somthing");
    goto Label1;
}
int x = Convert.ToInt32(xstr);
label2:
Console.WriteLine("number 2:");
string ystr = Console.ReadLine()+ "";
if (ystr == blank)
{
    Console.WriteLine("please type somthing");
    goto label2;
}
int y = Convert.ToInt32(ystr);
label3:
Console.WriteLine("number 3:");
string zstr = Console.ReadLine() + "";
if (zstr == blank)
{
    Console.WriteLine("please type somthing");
    goto label3;
}
int z = Convert.ToInt32(zstr);
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