Класс Queue<T> представляет обобщенную очередь в C#.
Он реализует структуру данных "очередь", где элементы добавляются в конец и извлекаются из начала очереди.
  
  Пример:
  
  ```
  Queue<string> queue = new Queue<string>();
queue.Enqueue("Apple");
queue.Enqueue("Banana");
queue.Enqueue("Cherry");

string item = queue.Dequeue(); // Извлекает "Apple"
```
