// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hva heter du ?");
var text = Console.ReadLine();
Console.WriteLine($"Hei og velkommen: {text}");


string text1 = Console.ReadLine();
string text2 = Console.ReadLine();
ReturnString();
void ReturnString()
{
    Console.WriteLine($"{text1}");
    if (text2 == "1")
    {
        ReturnString2();
    }
}


void ReturnString2()

{
    string word = "";
    for (int i = text1.Length - 1; i >= 0; i--)
    {
        word += text1[i];
    }
    Console.WriteLine(word);
}



