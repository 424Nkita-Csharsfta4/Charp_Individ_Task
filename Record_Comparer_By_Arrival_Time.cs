using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirScript_Indevid_Csharp
{
    /// <summary>
    /// Реализация интерфейса IComparer для сравнения записей
    /// </summary>
    internal class Record_Comparer_By_Arrival_Time: IComparer<Employee_Information>
    {
        /// <summary>
        /// Класс для сравнения объектов типа Employee_Information по времени прихода
        /// </summary>
        /// <param name="employee_x">Первый сотрудник для сравнения</param>
        /// <param name="employee_y">Второй сотрудник для сравнения</param>
        /// <returns>Результат сравнения времени прихода двух сотрудников</returns>
        public int Compare(Employee_Information employee_x, Employee_Information employee_y)
        {
            return employee_x.ArrivalTime.CompareTo(employee_y.ArrivalTime);
        }
    }
}
