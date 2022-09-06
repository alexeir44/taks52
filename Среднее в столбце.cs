int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// создание двумерного массива
int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int n = CorrectInput();
    Console.Write("Введите количество столбцов: ");
    int m = CorrectInput();
    int[,] matrix = new int[n, m];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<m; j++)
        {
            matrix[i,j] = new Random().Next(-9,10);
            if (matrix[i,j]<0)
                Console.Write(matrix[i,j]+" ");
            else
                Console.Write(" " + matrix[i,j]+" ");                    
        }
    Console.WriteLine();  
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    int sum = 0;
    double result;
    for (int i = 0; i<matrix.GetUpperBound(1) + 1; i++)
    {
        for (int j = 0; j<matrix.GetUpperBound(0) + 1; j++)
            sum += matrix[j,i];
    result =(double)sum / (double)(matrix.GetUpperBound(0) + 1);
    Console.WriteLine($"Среднее арефметическое в столбце {i+1} равно {result}");
    sum = 0;
    result = 0;
    }
}

//Код программы
int[,] twoDimensionalArray = CreateArray();
PrintMatrix(twoDimensionalArray);