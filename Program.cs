string[,] table = new string[2,5];
// String.Empty
table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++){
    for (int columns = 0; columns < 5; columns++){
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}


void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            System.Console.Write($"{matr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

// тут пример закрашивания картинки

double Factorial (double n) 
{
    if (n == 1) return 1;
    else return n * Factorial (n - 1);
}

for (int i = 1; i < 20; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");    
}

int Fibonacci (int n){
    if (n == 1 || n == 2){
        return 1;
    } else {
        return Fibonacci(n -1) + Fibonacci(n -2);
    }
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i} = {Fibonacci(i)}");
}

// Домашнее задание 
// Обход папок - рекурсия
// Тетрис - закрашивание клетки