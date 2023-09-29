// Программа, которая будет находить произведение двух матриц.

int[,]GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,]array = new int[rows, cols];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
          
void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] multiMatrix)
{
  for (int i = 0; i < multiMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multiMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      multiMatrix[i,j] = sum;
    }
  }
}
int[,]matrix1 = GetArray(2,2,1,10);
int[,]matrix2 = GetArray(2,2,1,10);
int[,]multiMatrix = new int[2,2];
PrintArray(matrix1);
PrintArray(matrix2);
MultiplyMatrix(matrix1, matrix2, multiMatrix);
PrintArray(multiMatrix);