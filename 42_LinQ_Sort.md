LINQ позволяет сортировать данные с использованием оператора orderby. 
Он применяется для упорядочивания элементов в результирующем наборе данных по указанному критерию.
Пример:


```
int[] numbers = { 5, 2, 1, 4, 3 };
var sortedNumbers = numbers.OrderBy(num => num);

foreach (var num in sortedNumbers)
{
    Console.WriteLine(num);
}
// Выводит:
// 1
// 2
// 3
// 4
// 5
```
