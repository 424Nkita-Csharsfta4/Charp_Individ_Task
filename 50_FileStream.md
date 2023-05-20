Для чтения и записи файлов в .NET Framework можно использовать класс FileStream. 
Он предоставляет более низкоуровневый доступ к данным в файле.

Пример чтения и записи файла с использованием `FileStream`:
```
string filePath = "example.bin";

byte[] dataToWrite = { 1, 2, 3, 4, 5 };

using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
{
    fileStream.Write(dataToWrite, 0, dataToWrite.Length);
}

byte[] dataToRead = new byte[dataToWrite.Length];

using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
{
    fileStream.Read(dataToRead, 0, dataToRead.Length);
}
```
