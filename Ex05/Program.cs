// Программа создает копию массива
int[] CreateRandomArray(int lenght, int min, int max)
{
	int[] array = new int[lenght];
	Random random = new Random();
	for (int i = 0; i < lenght; i++)
	{
		array[i] = random.Next(min, max + 1);
	}
	return array;
}

int[] CopyArray(int[] array)
{
	int[] newArr = new int[array.Length];

	for (int i = 0; i < array.Length; i++)
	{
	newArr[i] = array[i];	
	}

	return newArr;
}

void PrintNumbers(int[] array)
{
	System.Console.WriteLine(string.Join(", ", array));
}

int[] array = CreateRandomArray(10, 0, 100);
PrintNumbers(array);
int[] newArr = CopyArray(array);
PrintNumbers(newArr);
