using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirScript_Indevid_Csharp
{
    /// <summary>
    /// IComparer для сравнения записей о сотрудниках по должности.
    /// </summary>
    internal class Record_Comparer_By_Position : IComparer<Employee_Information>
    {
        /// <summary>
        /// Сравниваем две записи о сотрудниках по должности.
        /// </summary>
        /// <param name="employee_x">Первая запись о сотруднике.</param>
        /// <param name="employee_y">Вторая запись о сотруднике.</param>
        /// <returns>Результат сравнения должностей сотрудников.</returns>
        public int Compare(Employee_Information employee_x, Employee_Information employee_y)
        {
            return employee_x.Position.CompareTo(employee_y.Position);
        }
    }
}
