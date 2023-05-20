В C# делегаты позволяют определить тип, 
который представляет метод и позволяет передавать методы как параметры и использовать их для обратного вызова. 

Пример:

```
delegate void MyDelegate(string message);

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

MyDelegate del = new MyDelegate(PrintMessage);
del("Hello"); // Выводит "Hello"
```
