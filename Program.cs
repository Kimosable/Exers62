// Задача 62: Заполните спирально массив 4 на 4.
class Program
{
    static void Main(string[] args)
    {
        // Создать массив 4х4
        int[,] arr = new int[4, 4];

        // Заполнить массив по спирали
        int value = 1;
        int minRow = 0;
        int maxRow = 3;
        int minCol = 0;
        int maxCol = 3;

        while (value <= 16)
        {
            // Заполнить верхнюю строку
            for (int i = minCol; i <= maxCol; i++)
            {
                arr[minRow, i] = value;
                value++;
            }

            // Заполнить правый столбец
            for (int i = minRow + 1; i <= maxRow; i++)
            {
                arr[i, maxCol] = value;
                value++;
            }

            // Заполнить нижнюю строку
            for (int i = maxCol - 1; i >= minCol; i--)
            {
                arr[maxRow, i] = value;
                value++;
            }

            // Заполнить левый столбец
            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                arr[i, minCol] = value;
                value++;
            }

            // Уменьшить границы массива
            minRow++;
            maxRow--;
            minCol++;
            maxCol--;
        }

        // Вывести массив на экран
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}