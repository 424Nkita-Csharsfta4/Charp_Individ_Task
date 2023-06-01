using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gos_Administraciya_Tiraspol
{
    public class JournalEntry : IComparable<JournalEntry>
    {
        // Источник финансирования для записи в журнале
        public string FundingSource { get; set; }

        // Название фонда для записи в журнале
        public string FundName { get; set; }

        // Ответственное лицо за запись в журнале
        public string ResponsiblePerson { get; set; }

        // Статус записи в журнале
        public string Status { get; set; }         

        public int CompareTo(JournalEntry other)
        {
            // Сравнение по названию фонда в первую очередь
            int result = FundName.CompareTo(other.FundName);

            // Если названия фондов совпадают, сравниваем по ответственному лицу
            if (result == 0)
                result = ResponsiblePerson.CompareTo(other.ResponsiblePerson);

            return result;
        }
    }


}
