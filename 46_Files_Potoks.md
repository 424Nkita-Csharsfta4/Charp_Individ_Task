В .NET Framework предоставляются классы для работы с потоками данных,
включая чтение и запись файлов. Классы StreamReader и StreamWriter позволяют работать с текстовыми файлами, 
а класс FileStream предоставляет более низкоуровневый доступ к файлам.

Пример использования StreamReader для чтения текстового файла:
```
string path = "example.txt";

using (StreamReader reader = new StreamReader(path))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
```
