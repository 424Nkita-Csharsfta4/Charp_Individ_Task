Операции со структурой DateTime:
Структура DateTime предоставляет множество операций для работы с датой и временем. 
Некоторые из основных операций включают получение текущей даты и времени,
добавление или вычитание интервалов времени, 
сравнение дат и времени,
а также форматирование даты и времени в определенном формате.

```
DateTime date1 = new DateTime(2021, 5, 1);
DateTime date2 = DateTime.Now;

// Сравнение дат
if (date1 > date2)
{
    Console.WriteLine("Дата 1 позже даты 2");
}
else if (date1 < date2)
{
    Console.WriteLine("Дата 1 раньше даты 2");
}
else
{
    Console.WriteLine("Даты равны");
}

// Добавление интервала времени
DateTime newDate = date2.AddHours(2);
Console.WriteLine(newDate);

// Вычитание интервала времени
TimeSpan difference = date2 - date1;
Console.WriteLine(difference.TotalDays);
```
