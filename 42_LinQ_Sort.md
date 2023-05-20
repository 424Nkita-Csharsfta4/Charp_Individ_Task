LINQ позволяет фильтровать данные с использованием оператора where. 
Он применяется для указания условия, которому должны удовлетворять элементы, чтобы быть включенными в результат.

Пример:

```
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(num => num % 2 == 0);

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}
// Выводит:
// 2
// 4
```
