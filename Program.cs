//Условие:
//    Программа, которая:

//    Запрашивает у пользователя ввод числа N.
//    Создает массив из N случайных чисел в диапазоне от 1 до 100.
//    Выводит все четные числа из массива в одну строку, а нечетные — в другую.

Random random = new Random();


Console.WriteLine("Введите размер массива: ");

string nnumber = Console.ReadLine();
int.TryParse(nnumber, out int num);
int[] numbers = new int [num];


Console.WriteLine("Список четныйх числел: ");
for (int i = 0; i < num; i++)
{
    numbers[i] = random.Next(0, 100);
    if (numbers[i] % 2 == 0)
    {
        Console.Write(numbers[i] + ", ");
    }
}

Console.WriteLine("\n\nСписок нечетныйх числел: ");
for (int i = 0; i < num; i++)
{
    numbers[i] = random.Next(0, 100);
    if (numbers[i] % 2 != 0)
    {
        Console.Write(numbers[i] + ", ");
    }
}
// Ждем пока пользователь нажмет кнопку для того, чтобы закрыть программу
Console.ReadKey();
