В C# события представляют механизм, который позволяет объектам сообщать о 
происходящих событиях и позволяет другим объектам реагировать на эти события.
Пример создания и вызова события:

Пример:

```
class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}

Button button = new Button();
button.Click += (sender, e) => Console.WriteLine("Button clicked");
button.OnClick(); // Выводит "Button clicked"
```
