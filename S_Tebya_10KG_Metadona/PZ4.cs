using System;
using System.Collections.Generic;

public class Address
{
    // Адресные данные
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string ApartmentNumber { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Tenants { get; set; }

    // Конструктор класса
    public Address(string city, string street, string houseNumber, string apartmentNumber, string phoneNumber, List<string> tenants)
    {
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
        PhoneNumber = phoneNumber;
        Tenants = tenants;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создание объектов класса Address для 10 человек
        List<Address> addresses = CreateAddresses();

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Найти адрес по фамилии, имени, отчеству");
        Console.WriteLine("2. Найти ФИО по адресу (город, улица, дом)");
        Console.WriteLine("3. Найти адрес и ФИО по номеру телефона");
        Console.Write("Ваш выбор (1-3): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введите фамилию, имя, отчество: ");
                string fullName = Console.ReadLine();
                FindAddressByFullName(fullName, addresses);
                break;
            case 2:
                Console.Write("Введите адрес (город, улица, дом): ");
                string address = Console.ReadLine();
                FindFullNameByAddress(address, addresses);
                break;
            case 3:
                Console.Write("Введите номер телефона: ");
                string phoneNumber = Console.ReadLine();
                FindAddressAndFullNameByPhoneNumber(phoneNumber, addresses);
                break;
            default:
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите от 1 до 3.");
                break;
        }
    }

    // Метод для создания адресов 10 человек
    public static List<Address> CreateAddresses()
    {
        List<Address> addresses = new List<Address>();

        // Добавление адресов 10 человек
        addresses.Add(new Address("Город1", "Улица1", "1", "1", "1111111", new List<string> { "Фамилия1 Имя1 Отчество1" }));
        addresses.Add(new Address("Город2", "Улица2", "2", "2", "2222222", new List<string> { "Фамилия2 Имя2 Отчество2" }));
        addresses.Add(new Address("Город3", "Улица3", "3", "3", "3333333", new List<string> { "Фамилия3 Имя3 Отчество3" }));
        addresses.Add(new Address("Город4", "Улица4", "4", "4", "4444444", new List<string> { "Фамилия4 Имя4 Отчество4" }));
        addresses.Add(new Address("Город5", "Улица5", "5", "5", "5555555", new List<string> { "Фамилия5 Имя5 Отчество5" }));
        addresses.Add(new Address("Город6", "Улица6", "6", "6", "6666666", new List<string> { "Фамилия6 Имя6 Отчество6" }));
        addresses.Add(new Address("Город7", "Улица7", "7", "7", "7777777", new List<string> { "Фамилия7 Имя7 Отчество7" }));
        addresses.Add(new Address("Город8", "Улица8", "8", "8", "8888888", new List<string> { "Фамилия8 Имя8 Отчество8" }));
        addresses.Add(new Address("Город9", "Улица9", "9", "9", "9999999", new List<string> { "Фамилия9 Имя9 Отчество9" }));
        addresses.Add(new Address("Город10", "Улица10", "10", "10", "1010101", new List<string> { "Фамилия10 Имя10 Отчество10" }));

        return addresses;
    }

    // Метод для поиска адреса по фамилии, имени, отчеству
    public static void FindAddressByFullName(string fullName, List<Address> addresses)
    {
        bool found = false;

        foreach (Address address in addresses)
        {
            foreach (string tenant in address.Tenants)
            {
                if (tenant.Equals(fullName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Адрес: {address.City}, {address.Street}, {address.HouseNumber}, {address.ApartmentNumber}");
                    found = true;
                    break;
                }
            }

            if (found)
            {
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Адрес не найден для заданного ФИО.");
        }
    }

    // Метод для поиска ФИО по адресу (город, улица, дом)
    public static void FindFullNameByAddress(string address, List<Address> addresses)
    {
        bool found = false;

        foreach (Address addr in addresses)
        {
            string fullAddress = $"{addr.City}, {addr.Street}, {addr.HouseNumber}";

            if (fullAddress.Equals(address, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ФИО: {string.Join(", ", addr.Tenants)}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("ФИО не найдено для заданного адреса.");
        }
    }

    // Метод для поиска адреса и ФИО по номеру телефона
    public static void FindAddressAndFullNameByPhoneNumber(string phoneNumber, List<Address> addresses)
    {
        bool found = false;

        foreach (Address address in addresses)
        {
            if (address.PhoneNumber.Equals(phoneNumber))
            {
                Console.WriteLine($"Адрес: {address.City}, {address.Street}, {address.HouseNumber}, {address.ApartmentNumber}");
                Console.WriteLine($"ФИО: {string.Join(", ", address.Tenants)}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Адрес и ФИО не найдены для заданного номера телефона.");
        }
    }
}
