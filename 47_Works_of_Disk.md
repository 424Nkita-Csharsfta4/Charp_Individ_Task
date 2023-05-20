Работа с дисками и каталогами. Классы DriveInfo, Directory и DirectoryInfo:
В .NET Framework предоставляются классы для работы с дисками и каталогами. 
Класс DriveInfo позволяет получать информацию о дисках, 
а классы Directory и DirectoryInfo предоставляют функциональность 
для работы с каталогами (папками) на дисках.

Пример использования DriveInfo для получения информации о дисках:

```
DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Drive: {drive.Name}");
    Console.WriteLine($"  Drive type: {drive.DriveType}");
    Console.WriteLine($"  Total size: {drive.TotalSize}");
    Console.WriteLine($"  Available free space: {drive.AvailableFreeSpace}");
    Console.WriteLine();
}
```
Пример использования `Directory` для создания и удаления каталогов:
```
string directoryPath = "ExampleDirectory";

Directory.CreateDirectory(directoryPath);

if (Directory.Exists(directoryPath))
{
    Console.WriteLine("Directory created successfully.");
}

Directory.Delete(directoryPath);

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Directory deleted successfully.");
}
```
Пример использования `DirectoryInfo` для получения информации о каталоге:
```
string directoryPath = "ExampleDirectory";

DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

Console.WriteLine($"Directory name: {directoryInfo.Name}");
Console.WriteLine($"Parent directory: {directoryInfo.Parent}");
Console.WriteLine($"Creation time: {directoryInfo.CreationTime}");
```
