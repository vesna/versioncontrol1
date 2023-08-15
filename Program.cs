string[] GetStringsLessOrEqualThree(string[] input)
{
    int resultSize = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
            resultSize++;
    }

    string[] result = new string[resultSize];
    if (resultSize > 0)
    {
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[counter] = input[i];
                counter++;
            }
        }
    }
    return result;
}

string[] GenerateRandomArrayOfString(int size)
{
    string[] result = new string[size];
    Random rand = new Random();
    String str = "abcdefghijklmnopqrstuvwxyz";
    for (int j = 0; j < size; j++)
    {
        int stringlen = rand.Next(1, 10);
        String ran = "";
        for (int k = 0; k < stringlen; k++)
        {
            int x = rand.Next(26);
            ran = ran + str[x];
        }
        result[j] = ran;
    }
    return result;
}

void PrintArray(string[] input)
{
    Console.Write("[");
    for (int i = 0; i < input.Length; i++)
    {
        if (i == 0)
            Console.Write(input[i]);
        else
            Console.Write($", {input[i]}");
    }
    Console.Write("]");
}

int size;
Console.WriteLine("Укажите размер массива:");
if (!Int32.TryParse(Console.ReadLine(), out size))
{
    Console.WriteLine("Ошибка ввода");
    return;
}
if (size > 0)
{
    string[] inputStringArray = new string[size];
    Console.Write("Ввести {size} строк с клавиатуры? (Y/N)");
    string? answer = Console.ReadLine();
    answer = answer.ToUpper();
    switch (answer)
    {
        case "Y":
            Console.WriteLine("Введите массив строк: ");
            for (int i = 0; i < size; i++)
            {
                inputStringArray[i] = Console.ReadLine();
            }
            break;
        case "N":
            inputStringArray = GenerateRandomArrayOfString(size);
            break;
        default:
            Console.WriteLine("Ошибка ввода");
            break;
    }

    string[] resultStringArray = GetStringsLessOrEqualThree(inputStringArray);
    Console.Write("Исходный массив: ");
    PrintArray(inputStringArray);
    Console.WriteLine();
    Console.Write("Результат:");
    PrintArray(resultStringArray);
}


