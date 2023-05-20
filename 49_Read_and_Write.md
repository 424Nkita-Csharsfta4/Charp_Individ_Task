Чтение и запись текстовых файлов. 
Классы StreamReader и StreamWriter:
Для чтения и записи текстовых файлов в .NET Framework можно использовать классы StreamReader и StreamWriter.
Они предоставляют удобные методы для работы с текстовыми данными.

Пример чтения текстового файла с использованием `StreamReader`:
```
string filePath = "example.txt";

using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
```

Пример записи текстового файла с использованием `StreamWriter`:

```
string filePath = "example.txt";

using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Hello, World!");
    writer.WriteLine("This is a text file.");
}
```
