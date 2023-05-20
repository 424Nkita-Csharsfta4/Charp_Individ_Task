Методы расширения LINQ позволяют добавлять 
пользовательские методы к типам данных, 
чтобы использовать их в LINQ-запросах. 
Они представляют статические методы,
принимающие входной параметр типа,
к которому они применяются, и возвращающие результат.

Пример:

```
public static class StringExtensions
{
    public static bool IsLong(this string str)
    {
        return str.Length > 5;
    }
}

string[] names = { "John", "Alice", "Michael" };
var longNames = names.Where(name => name.IsLong());

foreach (var name in longNames)
{
    Console.WriteLine(name);
}
// Выводит:
// Michael
```
