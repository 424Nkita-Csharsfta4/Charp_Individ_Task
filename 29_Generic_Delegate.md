В C# также можно использовать обобщенные делегаты, которые могут принимать и возвращать различные типы данных. 
Некоторые обобщенные делегаты включают Action<T> (не возвращает значение) и Func<T, TResult> (возвращает значение). 
  
  Пример:
  ```
  Action<string> action = new Action<string>(Console.WriteLine);
action("Hello"); // Выводит "Hello"

Func<int, int, int> add = new Func<int, int, int>(AddNumbers);
int result = add(3, 5); // Возвращает 8

int AddNumbers(int a, int b)
{
    return a + b;
}
```
