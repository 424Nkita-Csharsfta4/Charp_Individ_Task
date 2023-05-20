Структура DateTime. Форматирование дат и времени:
Структура DateTime в C# представляет дату и время.
Она предоставляет различные методы для форматирования даты и времени в нужный формат. 

Например:

```
DateTime currentDate = DateTime.Now;
string formattedDate = currentDate.ToString("dd/MM/yyyy");
Console.WriteLine(formattedDate);
```
