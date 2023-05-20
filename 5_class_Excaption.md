В C# можно создавать пользовательские классы исключений, которые наследуются от класса Exception.
Это позволяет определить собственные типы исключений для конкретных ситуаций.

```
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}
```

Использование пользовательского класса исключения:

```
try
{
    if (someCondition)
    {
        throw new CustomException("Custom error occurred");
    }
}
catch (CustomException ex)
{
    // Обработка пользовательского исключения
}

```
