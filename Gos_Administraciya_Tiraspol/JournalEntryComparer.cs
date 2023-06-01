using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gos_Administraciya_Tiraspol
{
    using System.Collections.Generic;

    public class JournalEntryComparer : IComparer<JournalEntry>
    {
        public int Compare(JournalEntry x, JournalEntry y)
        {
            // Сравнение по источнику финансирования в первую очередь
            int result = x.FundingSource.CompareTo(y.FundingSource);

            // Если источники финансирования совпадают, сравниваем по названию фонда
            if (result == 0)
                result = x.FundName.CompareTo(y.FundName);

            return result;
        }
    }


}
