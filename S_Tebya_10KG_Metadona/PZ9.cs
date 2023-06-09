using System;

class Circle
{
    // Координаты центра окружности
    public double X { get; set; }
    public double Y { get; set; }

    // Радиус окружности
    public double Radius { get; set; }

    // Конструктор класса Circle
    public Circle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    // Метод для вычисления расстояния между центрами двух окружностей
    public double CalculateDistance(Circle otherCircle)
    {
        // Вычисляем разницу по координатам X и Y
        double dx = X - otherCircle.X;
        double dy = Y - otherCircle.Y;

        // Вычисляем расстояние с помощью теоремы Пифагора
        double distance = Math.Sqrt(dx * dx + dy * dy);

        return distance;
    }
}

class Programasda
{
    static void Mainss(string[] args)
    {
        // Создаем две окружности
        Circle circle1 = new Circle(0, 0, 5);
        Circle circle2 = new Circle(3, 4, 3);

        // Вычисляем расстояние между центрами окружностей
        double distance = circle1.CalculateDistance(circle2);

        // Выводим результат
        Console.WriteLine($"Расстояние между центрами окружностей: {distance}");
    }
}
