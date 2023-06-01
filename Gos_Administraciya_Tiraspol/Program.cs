using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gos_Administraciya_Tiraspol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список объектов JournalEntry
            List<JournalEntry> entries = new List<JournalEntry>
        { 
            new JournalEntry { FundingSource = "Грант1", FundName = "Проект3", ResponsiblePerson = "Иванов Иван", Status = "Завершено" },
            new JournalEntry { FundingSource = "Субсидия2", FundName = "Проект2", ResponsiblePerson = "Петров Петр", Status = "В процессе" },
            new JournalEntry { FundingSource = "Грант1", FundName = "Проект1", ResponsiblePerson = "Сидорова Анна", Status = "Не выполнено" },
            new JournalEntry { FundingSource = "Субсидия2", FundName = "Проект3", ResponsiblePerson = "Смирнов Алексей", Status = "Завершено" },

        };

            // Сортируем список с использованием IComparable<T>
            entries.Sort();

            Console.WriteLine("Отсортировано по названию фонда и ответственному лицу:");
            PrintEntries(entries);

            // Сортируем список с использованием IComparer<T>
            entries.Sort(new JournalEntryComparer());

            Console.WriteLine("\nОтсортировано по источнику финансирования и названию фонда:");
            PrintEntries(entries);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод PrintEntries используется для вывода информации о журнальных записях. 
        /// Он принимает список entries объектов типа JournalEntry.
        /// Каждая журнальная запись содержит информацию о источнике
        /// финансирования, названии фонда, ответственном лице и статусе.
        /// Внутри метода происходит вывод заголовков столбцов, чтобы ясно указать, 
        /// какая информация выводится в каждом столбце. 
        /// Затем происходит перебор всех объектов в списке entries и вывод информации
        /// о каждой записи в форматированном виде с помощью Console.WriteLine. 
        /// Каждое значение выравнивается по левому краю и имеет фиксированную ширину столбца 
        /// (15 символов), чтобы таблица выглядела аккуратно и читаемо.
        /// </summary>
        /// <param name="entries"></param>
        private static void PrintEntries(List<JournalEntry> entries)
        {
            // Вывод заголовков столбцов
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Источник финансирования", "Название фонда", "Ответственное лицо", "Статус");

            // Вывод информации об объектах
            foreach (var entry in entries)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", entry.FundingSource, entry.FundName, entry.ResponsiblePerson, entry.Status);
            }
        }

    }

}
