Анонимные методы в C# позволяют определить и использовать методы без явного объявления имени. 
Они часто используются для создания обработчиков событий или передачи в качестве аргументов методов.

Пример:

```
delegate void MyDelegate(string message);

MyDelegate del = delegate(string message)
{
    Console.WriteLine(message);
};

del("Hello"); // Выводит "Hello"
```
