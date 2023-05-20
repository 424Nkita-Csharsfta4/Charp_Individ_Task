Классы Dictionary<TKey, TValue> и SortedDictionary<TKey, TValue> представляют обобщенные словари в C#. 
Dictionary<TKey, TValue> предоставляет неупорядоченный словарь, где элементы хранятся в виде пар "ключ-значение". 
SortedDictionary<TKey, TValue> предоставляет упорядоченный словарь, где элементы автоматически сортируются по ключу.

Пример:
```
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Alice", 25);
ages.Add("Bob", 30);
ages.Add("Charlie", 35);

int age = ages["Alice"]; // Возвращает 25

SortedDictionary<int, string> sortedNames = new SortedDictionary<int, string>();
sortedNames.Add(3, "Charlie");
sortedNames.Add(1, "Alice");
sortedNames.Add(2, "Bob");

string name = sortedNames[1]; // Возвращает "Alice"
```
