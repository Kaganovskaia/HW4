/*Напишите программу, которая задаёт массив из 8 случайных целых чисел 
 и выводит отсортированный по модулю массив.
 -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
 6, 1, -33 -> [1, 6, -33] */

 /*Денис! Тут можно не проверять))) все идеально потому что я внаглую скатала
 с разбора домашки, ибо сама я как собака-понимаю, но не могу сообразить как)))
 теперь я сообразила)) */

 void Task29()
{
    int[] array=new int[8];
    Random random= new Random();

 for ( int i=0; i<array.Length; i++ )
 {
array [i]=random.Next(2, 13);
 }
System.Console.WriteLine();
System.Console.WriteLine("Вывод массива: " );

 for ( int i=0; i<array.Length; i++ )
 {
    System.Console.WriteLine( array [i] + "\t");
 }
 System.Console.WriteLine();

 for ( int i = array.Length-1; i>0; i--)
 {
    for ( int j=0; j<i; j++)
    {
        //if (array[j] > array[j+1] )
        if (Math.Abs(array[j]) > Math.Abs(array[j+1]) ) // это сортировка по модулю
        {
            int temp=array[j]; //это стандартная сотрировка пузырьком
            array[j]=array[j+1];
            array[j+1]=temp;

    
        }
    }
 }
System.Console.WriteLine();
System.Console.WriteLine("Вывод массива: " );

 for ( int i=0; i<array.Length; i++ )
 {
    System.Console.WriteLine( array [i] + "\t");
 }
 System.Console.WriteLine();

}
//int RaPower( )

Task29();
