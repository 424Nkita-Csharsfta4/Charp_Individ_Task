Определение структуры в C# осуществляется с помощью ключевого слова struct.
Структура может содержать поля и методы. 
Для создания объекта структуры используется ключевое слово new, 
за которым следует имя структуры и вызов конструктора (если он определен).

Пример:

```
struct Point
{
    public int X;
    public int Y;
}

Point p = new Point();
p.X = 10;
p.Y = 5;
```