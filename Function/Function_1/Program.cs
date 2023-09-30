// See https://aka.ms/new-console-template for more information



static int[,,]Get3DMatrix(int x, int y, int z, int min, int max)
       {
        int[,,] matrix = new int[x,y,z];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {  
                     matrix[i,j,k] = new Random().Next(min, max +1); 
                }
            }
        }
        return matrix;    
       }
static void Print3DMatrix(int[,,]array)
    {
     for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    
                    Console.Write(array[i, j, k]+"("+ i +","+ j +"," + k + ")") ;
                }
                Console.WriteLine();
            }
            
        }
    }    
    int[,,]matrix = Get3DMatrix(2,2,2,1,100);
    Print3DMatrix(matrix);
