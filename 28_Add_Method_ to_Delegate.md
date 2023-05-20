В C# можно добавлять несколько методов в один делегат с использованием оператора +=. 
При вызове делегата будут вызываться все добавленные методы. 

Пример:

```
delegate void MyDelegate();

void Method1()
{
    Console.WriteLine("Method 1");
}

void Method2()
{
    Console.WriteLine("Method 2");
}

MyDelegate del = new MyDelegate(Method1);
del += Method2;
del(); // Выводит "Method 1" и "Method 2"
```
