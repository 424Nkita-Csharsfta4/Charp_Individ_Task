Классы HashSet<T> и SortedSet<T> представляют обобщенные множества в C#. 
HashSet<T> предоставляет неупорядоченное множество, где элементы не повторяются. 
SortedSet<T> предоставляет упорядоченное множество, где элементы автоматически сортируются. 
  
 Пример:
  ```
  HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(3);
set.Add(2); // Добавление повторяющегося элемента игнорируется

SortedSet<string> sortedSet = new SortedSet<string>();
sortedSet.Add("Bob");
sortedSet.Add("Alice");
sortedSet.Add("Charlie");
```
