Вложенные структуры: В C# можно объявлять структуры внутри других структур, что называется вложенными структурами.
Вложенные структуры являются частью внешней структуры и могут использоваться только в контексте этой структуры.

Пример объявления вложенной структуры:

```
struct OuterStruct
{
    public int OuterField;

    public struct InnerStruct
    {
        public int InnerField;
    }
}

OuterStruct outer = new OuterStruct();
outer.OuterField = 10;

OuterStruct.InnerStruct inner = new OuterStruct.InnerStruct();
inner.InnerField = 20;
```
