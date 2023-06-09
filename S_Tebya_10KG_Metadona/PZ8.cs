using System;

class Programas
{
    static void Maina(string[] args)
    {
        // Полученный набор данных
        int[] data = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };

        // Максимально возможное значение
        int max = 50;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                // Проверка следующих 3 чисел
                if (i + 3 < data.Length)
                {
                    int sum = data[i + 1] + data[i + 2] + data[i + 3];
                    int average = sum / 3;
                    data[i] = average;

                    // Проверка следующих 10 чисел
                    if (i + 10 < data.Length)
                    {
                        sum = 0;
                        for (int j = i + 1; j <= i + 10; j++)
                        {
                            sum += data[j];
                        }
                        average = sum / 10;
                        data[i] = average;

                        // Проверка всей выборки
                        if (average > max)
                        {
                            sum = 0;
                            for (int j = 0; j < data.Length; j++)
                            {
                                sum += data[j];
                            }
                            average = sum / data.Length;
                            data[i] = average;

                            // Проверка результата
                            if (average > max)
                            {
                                Console.WriteLine("Ошибка: Полученное число слишком велико.");
                                return;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(data[i]);
        }
    }
}
