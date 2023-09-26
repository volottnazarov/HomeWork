// Изучение и практика по функциям
//=====Приветствие и умножение двух чисел
// static void WriteHello(string str)
// {
//     Console.WriteLine(str);
// }
// WriteHello("Привет");
// static int Multiply(int num_1,int num_2)
// {
//     return num_1*num_2;
// }
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int result = Multiply(num_1,num_2);
// Console.WriteLine("Результат:"+result);
//=====Программа , которая на вход принимает число А , на выходе сумму от 1 до А
// int Sum(int A)
// {
//     int sum = 0;
//     for(int i = 0 ; i <= A ; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число :");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(A));
//=====Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом
// увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы,
// m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
//и возвращает матрицу, удовлетворяющую этим условиям.

//Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

//Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает
// одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

//Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
//и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 -
// это значения средних значений столбцов, округленные до двух знаков после запятой,
// разделенные знаком табуляции.


using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
         Console.Write($"{matrix[i,j]}\t");
       }
       Console.WriteLine();
         
     }
      
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      int[,]array = new int[n,m];
      int current_number = 1;
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j <array. GetLength(1); j++)
        {
          array[i,j] = current_number;
          current_number += k;
        }
      }
    return array;
    }
  
    static void PrintListAvr (double [] list)
    {
      Console.WriteLine("The averages in columns are: ");
      for(int i = 0; i < list.Length; i++)
        Console.Write($"{list[i]:f}\t");
      Console.WriteLine();
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
     double[]res = new double[matrix.GetLength(1)];
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        double sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
          sum+=matrix[i,j];
        }
        res[j] = sum/matrix.GetLength(0);
      }
      return res;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           n = 3;
           m = 4;
           k = 2;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}