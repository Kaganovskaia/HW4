/* Напишите цикл, который принимает на вход два натуральных числа 
(A и B) и возводит число A в степень B.
3, 5 -> 243 (3 в степень 5) 
2, 4 -> 16  */
void Task25()
{
    System.Console.WriteLine("Введите первое натуральное число");
 int number1=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите второе натуральное число");
 int number2=Convert.ToInt32(Console.ReadLine());
 

    System.Console.WriteLine($"Число {number1} в степени {number2}: равно: {RaPower(number1, number2)} " );
 

}
int RaPower( int number1, int number2)
{
    int result=1;
    for ( int i=0; i< number2; i++)
    {
        result *=number1;
    }

return result;
}
Task25();