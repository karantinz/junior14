Console.WriteLine("Введите имя");
string name = Console.ReadLine();

int length = name.Length;
Console.WriteLine("Длина строки: " + length);

Console.WriteLine("Введите символ");
char symbol = char.Parse(Console.ReadLine());

Console.WriteLine("Введите ширину");
int width = int.Parse(Console.ReadLine());

Console.WriteLine("Введите высоту");
int height = int.Parse(Console.ReadLine());

int offset = 2;

for (int i = 0; i < height; i++)
{
	for (int j = 0; j < width; j++)
	{
		if (i == 0 || i == height - 1)
		{
            Console.Write(symbol);
        }
		else if (j == 0 || j == width - 1)
		{
            Console.Write(symbol);
        }
		else if (i == height / offset && j == (width - length) / offset)
		{
			Console.Write(name);
			j += length - 1;
		}
		else
		{
			Console.Write(" ");
		}
	}

	Console.WriteLine();
}