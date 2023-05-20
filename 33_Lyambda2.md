Лямбда-выражения могут быть переданы в качестве параметров методов,
что позволяет определить и использовать анонимные функции внутри других методов. 

Пример:

```
void ProcessNumbers(Func<int, int, int> operation)
{
    int result = operation(3, 5);
    Console.WriteLine(result);
}

ProcessNumbers((x, y) => x + y); // Выводит 8
```
