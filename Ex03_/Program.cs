// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 --> 101101
// 3 --> 11
// 2 --> 10
Console.WriteLine("Hello, World!");

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

string Conversion(int dec)
{
	string bin = "";
	while (dec > 0)
	{
		bin = dec % 2 + bin;
		dec = dec / 2;
		// if (dec % 2 == 0)
		// {
		// 	bin = "0" + bin;
		// }
		// else
		// {
		// 	bin = "1" + bin;
		// }
	}
	System.Console.WriteLine(bin);
	return bin;
}

Conversion(EnterNumber(""));