using System;

// Родительский класс "Сотрудник"
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор с параметрами
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Виртуальный метод для вывода информации о сотруднике
    public virtual void DisplayInformation()
    {
        Console.WriteLine($"Сотрудник: {Name}, Возраст: {Age}");
    }

    // Метод, скрывающий метод родителя
    public void Work()
    {
        Console.WriteLine("Работник выполняет свою работу.");
    }
}

// Класс "Рабочий" - наследник класса "Сотрудник"
public class Worker : Employee
{
    public string Position { get; set; }

    // Конструктор с параметрами, вызывает конструктор родителя
    public Worker(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    // Перегруженный метод DisplayInformation для вывода должности рабочего
    public override void DisplayInformation()
    {
        Console.WriteLine($"Рабочий: {Name}, Возраст: {Age}, Должность: {Position}");
    }

    // Метод Work, скрывающий метод родителя
    public new void Work()
    {
        Console.WriteLine("Рабочий выполняет физическую работу.");
    }
}

// Класс "Кадры" - наследник класса "Сотрудник"
public class HR : Employee
{
    public string Department { get; set; }

    // Конструктор с параметрами, вызывает конструктор родителя
    public HR(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    // Перегруженный метод DisplayInformation для вывода отдела кадров
    public override void DisplayInformation()
    {
        Console.WriteLine($"Кадры: {Name}, Возраст: {Age}, Отдел: {Department}");
    }

    // Метод Work, скрывающий метод родителя
    public new void Work()
    {
        Console.WriteLine("Кадры занимаются управлением персоналом.");
    }
}

// Класс "Администрация" - наследник класса "Сотрудник"
public class Administration : Employee
{
    public string Role { get; set; }

    // Конструктор с параметрами, вызывает конструктор родителя
    public Administration(string name, int age, string role) : base(name, age)
    {
        Role = role;
    }

    // Перегруженный метод DisplayInformation для вывода роли администрации
    public override void DisplayInformation()
    {
        Console.WriteLine($"Администрация: {Name}, Возраст: {Age}, Роль: {Role}");
    }

    // Метод Work, скрывающий метод родителя
    public new void Work()
    {
        Console.WriteLine("Администрация осуществляет управление организацией.");
    }
}

class Programss_PZ6
{
    static void Mains(string[] args)
    {
        // Создание объектов разных классов
        Worker worker = new Worker("Иван", 30, "Рабочий");
        HR hr = new HR("Елена", 40, "Кадры");
        Administration admin = new Administration("Алексей", 35, "Директор");

        // Вызов методов объектов
        worker.DisplayInformation();
        worker.Work();

        hr.DisplayInformation();
        hr.Work();

        admin.DisplayInformation();
        admin.Work();
    }
}
