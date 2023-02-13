// Программа выводит последовательность Фибоначчи
  
// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
                            // зело ругаеццо при косячном вводе
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

int EnterNumber(string name)
{
	int num;

	Console.Write($"Введите число {name}: ");
	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
		Console.Write($"Ну-ка, еще разок! {name} = ");
	}
	return num;
}

void Fibonacci(int num)
{
	int[] arr = new int [num];
	
	if (num > 2)
	{
		arr[0] = 0;
		arr[1] = 1;
		for (int i = 2; i < num; i++)
		{
		arr[i] = arr[i - 2] + arr[i - 1];
		}
		System.Console.WriteLine(string.Join(" ", arr));
	}
	else
	{
   	System.Console.WriteLine("Введите число больше 2");
	}		
}

Fibonacci(EnterNumber(""));
