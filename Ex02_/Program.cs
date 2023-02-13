//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
int EnterNumber(string name)
 {
    int num;

    Console.Write($"Введите число {name}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {name} = ");
    }
    return  num;
}

void Execution(int a, int b, int c)
{
	if ((a < b + c) && (b < a + c) && (c < a + b))
	{
		System.Console.WriteLine("Даннный набор размеров сторон адекватный");
	}
	else
	{
		System.Console.WriteLine("Даннный набор размеров сторон неадекватный");
	}
}

int a = EnterNumber("a");
int b = EnterNumber("b");
int c = EnterNumber("c");

System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);

Execution(a, b, c);
Console.WriteLine("Hello, World!");

// "Универсальный ввод"
/*void PrintArray<T>(T[] array)
{
	foreach (var item in array)
	{
		Console.WriteLine(item);
	}
}
*/