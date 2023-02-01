// №25
int NumberOne(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberTwo(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDegree1ToA(int a, int b)
{
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

int number1 = NumberOne("Введите число:");
if (number1 <= 0)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    int number2 = NumberTwo("Введите степень числа:");
    if (number2 <= 0)
    {
        Console.WriteLine("Введено неверное число");
    }
    else
    {
        int summa = GetDegree1ToA(number1, number2);
        Console.WriteLine(summa);
    }
}


// №27 
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int a)
{
    int x = a;
    int sum = 0;
    int remainder = 0;
    while (x > 0)
    {
        remainder = x % 10;
        sum = sum + remainder;
        x = x / 10;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number > 0)
{
    int summa = GetSum(number);
    Console.WriteLine(summa);
}
else
{
    Console.WriteLine("Введено неверное число");
}



// №29
int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0 };



void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}




void SelectionSort(int[] array)
{
    int num = 1;
    string h = String.Empty;

    for (int i = 0; i < 8; i++)
    {
        if (num == 1) h = "первый";
        if (num == 2) h = "второй";
        if (num == 3) h = "третий";
        if (num == 4) h = "четвертый";
        if (num == 5) h = "пятый";
        if (num == 6) h = "шестой";
        if (num == 7) h = "седьмой";
        if (num == 8) h = "восьмой";

        Console.Write($"Введите {h} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
        num += 1;
    }
    Console.WriteLine();
}

SelectionSort(arr);
PrintArray(arr);