Делегат Action в C# представляет метод, который не возвращает значения и может принимать от 0 до 16 параметров. 
Он часто используется для передачи методов без возвращаемого значения.

Пример:
```
Action<string> printMessage = (message) => Console.WriteLine(message);
printMessage("Hello"); // Выводит "Hello"
```
