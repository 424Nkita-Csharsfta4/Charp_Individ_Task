В .NET Framework предоставляются классы File и FileInfo для работы с файлами.
Эти классы позволяют выполнять операции чтения, записи, перемещения и удаления файлов.

Пример использования `File` для проверки существования файла:
```
string filePath = "example.txt";

if (File.Exists(filePath))
{
    Console.WriteLine("File exists.");
}
else
{
    Console.WriteLine("File does not exist.");
}
```
Пример использования `FileInfo` для получения информации о файле:

```
string filePath = "example.txt";

FileInfo fileInfo = new FileInfo(filePath);

Console.WriteLine($"File name: {fileInfo.Name}");
Console.WriteLine($"File size: {fileInfo.Length} bytes");
Console.WriteLine($"Last write time: {fileInfo.LastWriteTime}");
```
