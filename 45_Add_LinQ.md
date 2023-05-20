LINQ позволяет получать только часть коллекции с использованием операторов Skip() и Take(). 
Они применяются для пропуска определенного количества элементов и взятия определенного количества элементов из исходной коллекции соответственно. 

Пример:
```
int[] numbers = { 1, 2, 3, 4, 5 };
var skippedNumbers = numbers.Skip(2);
var takenNumbers = numbers.Take(3);

foreach (var num in skippedNumbers)
{
    Console.WriteLine(num);
}
// Выводит:
// 3
// 4
// 5

foreach (var num in takenNumbers)
{
    Console.WriteLine(num);
}
// Выводит:
// 1
// 2
// 3
```
