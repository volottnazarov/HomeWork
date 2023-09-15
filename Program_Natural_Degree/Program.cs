// Программа цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int NaturalDegree(int A, int B)
{
    int degree = 1;
    for(int i = 1; i <= B; i++)
    {
        degree = degree*A;
    }
    return degree;
}
Console.WriteLine("Введите два числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = NaturalDegree(A , B);
Console.WriteLine(result);
