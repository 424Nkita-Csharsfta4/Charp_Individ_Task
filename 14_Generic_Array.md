Обобщенные классы. Статические поля обобщенных классов:
Обобщенные классы в C# позволяют создавать классы, параметризованные типом данных.
Они могут содержать статические поля, которые будут общими для всех экземпляров класса, независимо от параметра типа.

Пример:

```
class GenericClass<T>
{
    public static int staticField;

    public void PrintStaticField()
    {
        Console.WriteLine(staticField);
    }
}

GenericClass<int>.staticField = 10;
GenericClass<string>.staticField = 20;

GenericClass<int> instance1 = new GenericClass<int>();
instance1.PrintStaticField(); // Выводит 10

GenericClass<string> instance2 = new GenericClass<string>();
instance2.PrintStaticField(); // Выводит 20
```
