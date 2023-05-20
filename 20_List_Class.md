Классы List<T> и LinkedList<T> представляют обобщенные списки в C#.
List<T> предоставляет динамический массив, а LinkedList<T> - двусвязный список.

Пример:
  
  ```
  List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

LinkedList<string> names = new LinkedList<string>();
names.AddLast("Alice");
names.AddLast("Bob");
names.AddLast("Charlie");
```
