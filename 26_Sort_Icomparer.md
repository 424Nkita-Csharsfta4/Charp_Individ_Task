Сортировка объектов произвольного типа. 
Интерфейс IComparer:
Для сортировки объектов произвольного типа в C# можно использовать интерфейс IComparer. 
Он определяет метод Compare(), который позволяет задать критерии сортировки. 

Пример:
```
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class AgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}

List<Person> people = new List<Person>();
people.Add(new Person { Name = "Alice", Age = 25 });
people.Add(new Person { Name = "Bob", Age = 30 });

people.Sort(new AgeComparer()); // Сортирует по возрасту
```
