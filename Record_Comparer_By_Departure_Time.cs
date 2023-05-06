using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirScript_Indevid_Csharp
{
    /// <summary>
    /// IComparer сравнения по времени ухода.
    /// </summary>
    internal class Record_Comparer_By_Departure_Time : IComparer<Employee_Information>
    {
        /// <summary>
        /// Сравнивает два объекта по времени ухода сотрудников.
        /// </summary>
        /// <param name="employee_x">Первый сотрудник для сравнения</param>
        /// <param name="employee_y">Второй сотрудник для сравнения</param>
        /// <returns>результат сравнения.</returns>
        public int Compare(Employee_Information employee_x, Employee_Information employee_y)
        {
            return employee_x.DepartureTime.CompareTo(employee_y.DepartureTime);
        }
    }
}
