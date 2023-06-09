using System;
using System.Collections.Generic;

// Абстрактный класс для геометрической фигуры
public abstract class Shape
{
    // Метод для расчета объема фигуры
    public abstract double CalculateVolume();

    // Метод для расчета площади поверхности фигуры
    public abstract double CalculateSurfaceArea();
}

// Класс для шара
public class Sphere : Shape
{
    private double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateVolume()
    {
        return (4 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    public override double CalculateSurfaceArea()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }
}

// Класс для цилиндра
public class Cylinder : Shape
{
    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public override double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }

    public override double CalculateSurfaceArea()
    {
        double baseArea = Math.PI * Math.Pow(radius, 2);
        double lateralArea = 2 * Math.PI * radius * height;
        return 2 * baseArea + lateralArea;
    }
}

// Класс для поиска квартир по номеру или фамилии
public class ApartmentSearch
{
    private Apartment[] apartments;

    public ApartmentSearch(Apartment[] apartments)
    {
        this.apartments = apartments;
    }

    public Apartment FindApartmentByNumber(int number)
    {
        foreach (Apartment apartment in apartments)
        {
            if (apartment.Number == number)
            {
                return apartment;
            }
        }

        return null;
    }

    public Apartment[] FindApartmentsByLastName(string lastName)
    {
        List<Apartment> foundApartments = new List<Apartment>();

        foreach (Apartment apartment in apartments)
        {
            if (apartment.TenantLastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                foundApartments.Add(apartment);
            }
        }

        return foundApartments.ToArray();
    }
}

// Класс для представления квартиры
public class Apartment
{
    public int Number { get; set; }
    public string TenantLastName { get; set; }

    public Apartment(int number, string tenantLastName)
    {
        Number = number;
        TenantLastName = tenantLastName;
    }
}

// Пример использования программы
public class Programs
{
    public static void Main(string[] args)
    {
        // Создание объектов фигур
        Shape sphere = new Sphere(5);
        Shape cylinder = new Cylinder(3, 7);

        // Расчет объема и площади поверхности
        double sphereVolume = sphere.CalculateVolume();
        double sphereSurfaceArea = sphere.CalculateSurfaceArea();

        double cylinderVolume = cylinder.CalculateVolume();
        double cylinderSurfaceArea = cylinder.CalculateSurfaceArea();

        // Вывод результатов
        Console.WriteLine("Шар:");
        Console.WriteLine("Объем: " + sphereVolume);
        Console.WriteLine("Площадь поверхности: " + sphereSurfaceArea);

        Console.WriteLine();

        Console.WriteLine("Цилиндр:");
        Console.WriteLine("Объем: " + cylinderVolume);
        Console.WriteLine("Площадь поверхности: " + cylinderSurfaceArea);

        // Создание списка квартир
        Apartment[] apartments = new Apartment[]
        {
            new Apartment(101, "Иванов"),
            new Apartment(102, "Петров"),
            new Apartment(201, "Сидоров"),
            new Apartment(202, "Иванов"),
            new Apartment(301, "Смирнов"),
        };

        // Создание объекта для поиска квартир
        ApartmentSearch apartmentSearch = new ApartmentSearch(apartments);

        // Пример поиска по номеру квартиры
        int apartmentNumber = 202;
        Apartment foundApartment = apartmentSearch.FindApartmentByNumber(apartmentNumber);

        if (foundApartment != null)
        {
            Console.WriteLine($"Найдена квартира с номером {apartmentNumber}: {foundApartment.TenantLastName}");
        }
        else
        {
            Console.WriteLine($"Квартира с номером {apartmentNumber} не найдена.");
        }

        // Пример поиска по фамилии квартиросъемщика
        string tenantLastName = "Иванов";
        Apartment[] foundApartments = apartmentSearch.FindApartmentsByLastName(tenantLastName);

        if (foundApartments.Length > 0)
        {
            Console.WriteLine($"Найдены квартиры для квартиросъемщика {tenantLastName}:");
            foreach (Apartment apartment in foundApartments)
            {
                Console.WriteLine($"Квартира номер {apartment.Number}");
            }
        }
        else
        {
            Console.WriteLine($"Квартиры для квартиросъемщика {tenantLastName} не найдены.");
        }
    }
}
