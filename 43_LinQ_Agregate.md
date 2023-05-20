LINQ позволяет выполнять агрегатные операции над данными, такие как подсчет, суммирование, 
нахождение минимального или максимального значения и др. 
Операторы Count(), Sum(), Min(), Max() и другие используются для выполнения этих операций.
Пример:

Пример:

```
int[] numbers = { 1, 2, 3, 4, 5 };
int count = numbers.Count();
int sum = numbers.Sum();
int min = numbers.Min();
int max = numbers.Max();

Console.WriteLine(count); // Выводит 5
Console.WriteLine(sum); // Выводит 15
Console.WriteLine(min); // Выводит 1
Console.WriteLine(max); // Выводит 5
```
