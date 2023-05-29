using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirScript_Indevid_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            /// <summary>
            /// Выполнить список работ, согласно теме:
            /// «Создание приложения Журнал учета посещения сотрудниками работы» на базе ООО «Тирскрипт»
            /// Описать класс, соответствующий заданию.
            /// Создать коллекцию из объектов данного класса.
            /// Вывести информацию обо всех объектах.
            /// Отсортировать список объектов по возрастанию по различным
            /// полям(использовать интерфейсы IComparable<T>, IComparer<T>).
            /// Вывести отсортированные списки в табличном виде.
            /// Журнал учета посещения сотрудниками работы:
            ///•ФИО сотрудника;
            ///•Должность;
            ///•дата и время прихода;
            ///•дата и время ухода.
            /// Отсортировать список объектов по полям:
            ///•ФИО сотрудника;
            ///•	должность;
            ///•	дата и время прихода;
            ///•	дата и время ухода.
            /// Анализ предметной области, выделение ключевых объектов взаимодействия.
            /// Разработка кода программного продукта
            /// Документирование программного кода
            /// Тестирование программного продукта
            /// Составление инструкции пользователя программного продукта
            /// </summary>

            /// <summary>
            /// Создание списка с информацией о сотрудниках и добавление нового сотрудника в список.
            /// </summary>
            List<Employee_Information> employees_information = new List<Employee_Information> ();


            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Мошой Никита Валерьевич", "Директор",
                                      new DateTime(2022, 5, 1, 13, 0, 0),
                                      new DateTime(2022, 5, 1, 22, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Султанов Владислав Анатольевич", "Директок по цифровому развитию",
                                      new DateTime(2022, 5, 1, 13, 0, 0),
                                      new DateTime(2022, 5, 1, 22, 0, 0)));

            employees_information.Add(new Employee_Information("Иванов Иван Иванович", "Devops Программист",
                           new DateTime(2022, 5, 1, 8, 0, 0),
                           new DateTime(2022, 5, 1, 17, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Михаил Владимирович Донской", "Backend Программист",
                          new DateTime(2022, 5, 1, 8, 0, 0),
                          new DateTime(2022, 5, 1, 17, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Максим Николаевич Новичков", "Дизайнер",
                          new DateTime(2022, 7, 1, 8, 0, 0),
                          new DateTime(2022, 5, 1, 17, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Дмитрий Витальевич Крюков", "Тестировщик",
                          new DateTime(2022, 8, 1, 8, 0, 0),
                          new DateTime(2022, 5, 1, 17, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Александров Александр Александрович", "Mobile App Программист",
                                      new DateTime(2022, 5, 1, 9, 0, 0),
                                      new DateTime(2022, 5, 1, 18, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Сергеев Сергей Сергеевич", "Бизнес аналитик",
                                      new DateTime(2022, 5, 1, 10, 0, 0),
                                      new DateTime(2022, 5, 1, 19, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Петров Петр Петрович", "Тестировщик",
                                      new DateTime(2022, 5, 1, 11, 0, 0),
                                      new DateTime(2022, 5, 1, 20, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Николаев Николай Николаевич", "Backend Программист",
                                      new DateTime(2022, 5, 1, 12, 0, 0),
                                      new DateTime(2022, 5, 1, 21, 0, 0)));

            // Добавление записи в список сотрудников
            employees_information.Add(new Employee_Information("Владимиров Владимир Владимирович", "Дизайнер",
                                      new DateTime(2022, 5, 1, 13, 0, 0),
                                      new DateTime(2022, 5, 1, 22, 0, 0)));

            //Все зариси:
            Console.WriteLine("Все записи: ");
            Print_Employee_Information(employees_information);

            //Записи, отсортированные по ФИО сотрудника:
            employees_information.Sort();
            Console.WriteLine("\nЗаписи, отсортированные по ФИО сотрудника: ");
            Print_Employee_Information(employees_information);

            //Записи, отсортированные по должности:
            employees_information.Sort(new Record_Comparer_By_Position());
            Console.WriteLine("\nЗаписи, отсортированные по должности: ");
            Print_Employee_Information(employees_information);

            //Записи, отсортированные по дате и времени прихода:
            employees_information.Sort(new Record_Comparer_By_Arrival_Time());
            Console.WriteLine("Записи, отсортированные по дате и времени прихода: ");
            Print_Employee_Information(employees_information);

            //Записи, отсортированные по дате и времени ухода:
            employees_information.Sort(new Record_Comparer_By_Departure_Time());
            Console.WriteLine("\nЗаписи, отсортированные по дате и времени ухода:");
            Print_Employee_Information(employees_information);

        }
        /// <summary>
        ///  Print_Employee_Information вывод информации о сотрудниках в консоль
        /// </summary>

        /// <returns>Список с информацией о сотрудниках, включая нового сотрудника</returns>
        static void Print_Employee_Information(List<Employee_Information> records)
        {
            Console.WriteLine("ФИО сотрудника\tДолжность\tДата и время прихода\tДата и время ухода");
            //Вывод информации о каждом сотруднике
            foreach (Employee_Information employee_Information in records)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    employee_Information.FullName,
                    employee_Information.Position,
                    employee_Information.ArrivalTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    employee_Information.DepartureTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
    }
}
