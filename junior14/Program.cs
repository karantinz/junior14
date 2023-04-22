Console.Write("Введите имя: ");
string name = Console.ReadLine();

int length = name.Length;
Console.WriteLine("Длина строки: " + length);

Console.Write("Введите символ: ");
char symbol = char.Parse(Console.ReadLine());

int width = name.Length + 4;

string symbolWidth = "";

for (int i = 0; i < width; i++)
{
    symbolWidth += symbol;
}

Console.WriteLine(symbolWidth);
Console.WriteLine($"{symbol} {name} {symbol}");
Console.WriteLine(symbolWidth);
