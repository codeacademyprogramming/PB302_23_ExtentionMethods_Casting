using Lesson;


Console.WriteLine(Calculator.Multiply(4,5));
Console.WriteLine(Calculator.Multiply(4, 6));
Console.WriteLine(Calculator.Multiply(4, 7));
Console.WriteLine(Calculator.Multiply(4, 8));
Console.WriteLine(Calculator.Divide(4, 8));


Console.WriteLine(Calculator.UsageCount);

string text = "salam ala necesen?";

var result1 = StringExtention.GetFirstWord(text);
result1 = text.GetFirstWord();

Console.WriteLine(result1);

int num = 10;

int result2 = num.Add(20);
Console.WriteLine(result2);

Console.WriteLine(num.Sqrt());

var result3 = StringExtention.GetUpper(text, 4);
result3 = text.GetUpper(4);

Human hmn1 = new Human
{
    Name = "Hikmet",
    Surname = "Abbasov"
};

hmn1.GetFullName();






