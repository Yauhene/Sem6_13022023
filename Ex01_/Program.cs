// Программа "разворачивает" массив
Console.WriteLine("Hello, World!");
int [] arr = new int [5];

RandomArr(arr);
Console.WriteLine(string.Join(" ",arr));
SwithArr(arr);
Console.WriteLine(string.Join(" ",arr));
void RandomArr(int [] arr)
{
    Random random = new Random();

    for(int i=0; i<arr.Length;i++)
    {
        arr[i]=random.Next();
    }

}

void SwithArr(int [] arr)
{
    int a=0;
    for(int i=0;i<arr.Length/2;i++)
    {
        a = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = a;
    }
}