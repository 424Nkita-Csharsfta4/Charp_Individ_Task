Обобщенные методы:
Обобщенные методы в C# позволяют создавать методы, 
которые могут принимать и возвращать различные типы данных. 
Они объявляются с использованием параметра типа в угловых скобках.

Пример:

```
public T GetMax<T>(T a, T b)
{
    return Comparer<T>.Default.Compare(a, b) > 0 ? a : b;
}

int maxInt = GetMax(5, 10);
Console.WriteLine(maxInt);

string maxString = GetMax("apple", "banana");
Console.WriteLine(maxString);
```
