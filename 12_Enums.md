Перечисления:
Перечисления (enum) в C# позволяют создавать пользовательские типы данных,
которые содержат набор константных значений.
Они удобны для определения и использования ограниченных наборов значений. 

Пример:

```
enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

DaysOfWeek currentDay = DaysOfWeek.Wednesday;
Console.WriteLine(currentDay);
```
