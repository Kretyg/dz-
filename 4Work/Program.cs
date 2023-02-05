// Написать программу копирования массива

Console.Write("- Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());
Console.WriteLine(""); 

Console.Write("Массив: "); 
double[] array = new double[length];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10);
    Console.Write(array[i]);
    if (i < length - 1 ) Console.Write("; ");
}
Console.WriteLine(" "); 
Console.Write("Копия массива: ");  
double[] array1 = new double[length];
 
for (int i = 0; i < length; i++)
{
    array1[i] = array[i];
    Console.Write(array[i] + " ");
}