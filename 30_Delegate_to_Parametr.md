В C# можно передавать делегаты в качестве параметров методов, что позволяет вызывать различные методы через делегат. 

Пример:

```
delegate void MyDelegate(string message);

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

void ProcessMessage(MyDelegate del, string message)
{
    del(message);
}

ProcessMessage(PrintMessage, "Hello"); // Выводит "Hello"
```
