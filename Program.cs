/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// Создаём метод
Console.WriteLine("Зададим количество строк в двумерном массиве ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим количество столбцов в массиве ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим минимальное число в матрице ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим маексимальное число в матрице ");
int maxValue = Convert.ToInt32(Console.ReadLine());
//===================================================================
int[,] GetMatrix()
{

    int[,] matrix = new int[rows, cols];

    // теперь ЗАПОЛНЯЕМ двумерный массив    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);// рандомное число в  диапозоне c консоли
        }
    }
    return matrix;  // вернули заполненную табличку
}
//=======================================================================

// Для того, чтобы увидеть это на экране создаём метод void
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по всем строчкам    
    {
        for (int j = 0; j < matr.GetLength(1); j++) // проход по всем столбцам     
        {
            Console.Write(matr[i, j] + "\t"); //  печать строки с 4 пробелами между цифрами
        }
        Console.WriteLine();
    }
}
//Вызовем наш метод

// первым делом нужно создать массив
// Создание массива - это метод под названием GetMatrix 
// Создаем двумерный массив
// в нашу таблицу resultMatrix должна попасть заполненная таблица с числами от min до max
// чтобы esultMatrix заполнилась значениями мы вызываем метод GetMatrix и в скобках пусто - данные с консоли.
int[,] resultMatrix = GetMatrix();

Console.WriteLine(" У нас получилась вот такая матрица ");
PrintMatrix(resultMatrix); // Печать матрицы полностью

// Создадим метод для решения 

// Если мы ни чего не будем делать с результатами
// а просто их печатать, то метод void

// метод не видит матрицу, поэтому передаём её в круглые скобки


void SumMatrix(int[,] inputMatrix)
{
    for (int j = 0; j < inputMatrix.GetLength(1); j++)    // раз нужны результаты столбца, то считать будем столбцы
                                                         // проходя по строкам
    {
        double sum = 0;  // Заведём переменную, куда будем складывать результат
        double rezalt = 0; // И ещё одну переменную для удобства
        for (int i = 0; i < inputMatrix.GetLength(0); i++)   // и прыгаем по строкам   
        {                          
                sum = sum + inputMatrix[i, j];  //Считаем сумму
                //Сумма всех чисел столбца деленная на количество строк   
                rezalt = sum /inputMatrix.GetLength(0);  // высчитываем среднее арифметическое        
        }
        Console.WriteLine($" Результат для столбца   {j}  сумма в столбце =  {sum}. Среднее арифметическое  =  {rezalt}");              
        }   
}

Console.WriteLine(" ");
SumMatrix(resultMatrix);




