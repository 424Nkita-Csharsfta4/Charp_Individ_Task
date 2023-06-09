using System;

class Programasdas
{
    // Объявление делегата для диалога
    delegate void DialogDelegate(int messageNumber);

    static void Main(string[] args)
    {
        // Определение языка диалога
        Console.WriteLine("Выберите язык (1 - Русский, 2 - English, 3 - Українська):");
        int languageChoice = int.Parse(Console.ReadLine());

        // Создание экземпляра делегата на основе выбранного языка
        DialogDelegate dialogDelegate;
        switch (languageChoice)
        {
            case 1:
                dialogDelegate = RussianDialog;
                break;
            case 2:
                dialogDelegate = EnglishDialog;
                break;
            case 3:
                dialogDelegate = UkrainianDialog;
                break;
            default:
                Console.WriteLine("Выбран некорректный язык.");
                return;
        }

        // Выполнение диалога с помощью делегата
        dialogDelegate(1);
        dialogDelegate(2);
        dialogDelegate(3);
        dialogDelegate(4);
        dialogDelegate(5);
    }

    // Функция для диалога на русском языке
    static void RussianDialog(int messageNumber)
    {
        switch (messageNumber)
        {
            case 1:
                Console.WriteLine("Привет!");
                break;
            case 2:
                Console.WriteLine("Как тебя зовут?");
                break;
            case 3:
                Console.WriteLine("Сколько тебе лет?");
                break;
            case 4:
                Console.WriteLine("Что ты умеешь?");
                break;
            case 5:
                Console.WriteLine("Пока!");
                break;
            default:
                Console.WriteLine("Некорректный номер сообщения.");
                break;
        }
    }

    // Функция для диалога на английском языке
    static void EnglishDialog(int messageNumber)
    {
        switch (messageNumber)
        {
            case 1:
                Console.WriteLine("Hello!");
                break;
            case 2:
                Console.WriteLine("What is your name?");
                break;
            case 3:
                Console.WriteLine("How old are you?");
                break;
            case 4:
                Console.WriteLine("What can you do?");
                break;
            case 5:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid message number.");
                break;
        }
    }

    // Функция для диалога на украинском языке
    static void UkrainianDialog(int messageNumber)
    {
        switch (messageNumber)
        {
            case 1:
                Console.WriteLine("Привіт!");
                break;
            case 2:
                Console.WriteLine("Як вас звати?");
                break;
            case 3:
                Console.WriteLine("Скільки вам років?");
                break;
            case 4:
                Console.WriteLine("Що ви вмієте робити?");
                break;
            case 5:
                Console.WriteLine("До побачення!");
                break;
            default:
                Console.WriteLine("Некоректний номер повідомлення.");
                break;
        }
    }
}
