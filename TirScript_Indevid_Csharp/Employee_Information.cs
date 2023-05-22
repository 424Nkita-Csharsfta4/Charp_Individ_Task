using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TirScript_Indevid_Csharp
{
    internal class Employee_Information: IComparable<Employee_Information>
    {
        /// <summary>
        /// Полное имя сотрудника
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Время прибытия сотрудника
        /// </summary>
        public DateTime ArrivalTime { get; set; }
        /// <summary>
        /// Время выезда сотрудника
        /// </summary>
        public DateTime DepartureTime { get; set; }
        public Employee_Information(string name, string position, DateTime arrivalTime, DateTime departureTime)
        {
            FullName = name;
            Position = position;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }

        /// <summary>
        /// Реализация интерфейса IComparable для сравнения записей по ФИО сотрудника
        /// </summary>
        /// <param name="employee">Сотрудник для сравнения</param>
        /// <returns>Результат сравнения (-1, 0 или 1)</returns>
        public int CompareTo(Employee_Information employee)
        {
            return this.FullName.CompareTo(employee.FullName);
        }

        /// <summary>
        /// Переопределение метода ToString() для вывода информации о записи
        /// </summary>
        /// <returns>Информация о записи в виде строки</returns>
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", FullName, Position, ArrivalTime, DepartureTime);
        }

    }
}
