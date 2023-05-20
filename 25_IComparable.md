Сравнение произвольных типов в C#. Интерфейс IComparable:
В C# для сравнения произвольных типов можно использовать интерфейс IComparable.
Он определяет метод CompareTo(), который позволяет сравнивать объекты на основе их значений.

Пример:

```
class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        return Age.CompareTo(other.Age);
    }
}

Person person1 = new Person { Name = "Alice", Age = 25 };
Person person2 = new Person { Name = "Bob", Age = 30 };

int result = person1.CompareTo(person2); // Возвращает -1, так как person1 младше person2
```
