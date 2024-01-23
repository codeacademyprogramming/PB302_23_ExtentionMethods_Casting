

using Lesson2;
using System.Net.WebSockets;

byte numByte = 45;
string numStr = "5";

int numInt = numByte;

numInt = 1000000;
numByte = (byte)numInt;
Console.WriteLine(numByte);
numByte = Convert.ToByte(numInt);

Console.WriteLine(numByte);

numInt = Convert.ToInt32(numStr);
numInt = int.Parse(numStr);

Console.WriteLine(numInt);

Console.WriteLine(Calculator.Sum(10,5,20,40,4,56,76));





