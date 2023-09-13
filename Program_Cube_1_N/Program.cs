//Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N)
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
public class Answer
{
   static int ShowCube(int N)
    {
      // Введите свое решение ниже
     int cube_digit = 0;
       for (int i = 1; i <= N; i++)
         { 
          cube_digit = i*i*i;
          } 
          return cube_digit;
    }
    static void Print(int N)
    {
    int print_digit = 0;
    for (int i = 1; i <= N; i++)
    {
        print_digit = i*i*i;
        Console.WriteLine(print_digit);
    }
    
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
        Print(N);
    }
}
