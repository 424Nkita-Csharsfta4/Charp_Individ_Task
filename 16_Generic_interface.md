Обобщенные интерфейсы в C# определяют контракт, который должен быть реализован классами с определенным типом данных. 
Они объявляются с использованием параметра типа в угловых скобках. 

Пример:
```
interface IGenericInterface<T>
{
    void DoSomething(T value);
}

class MyClass<T> : IGenericInterface<T>
{
    public void DoSomething(T value)
    {
        Console.WriteLine(value);
    }
}

MyClass<int> myObj = new MyClass<int>();
myObj.DoSomething(5); // Выводит 5
```
