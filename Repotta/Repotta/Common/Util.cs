using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repotta.DBClass;
using static Repotta.DBClass.DBBase.WorkingMasterEnum;

namespace Repotta.Common
{
    public static class Util
    {
        public static DataTable GetDummyWorkingMaster()
        {
            DataTable wDataTable = new DataTable();
            Enum.GetValues(typeof(DBBase.WorkingMasterEnum)).Cast<Enum>().ToList().ForEach(x =>
            {
                wDataTable.Columns.Add(x.ToString());
            });
            wDataTable.Rows.Add();
            Action<DBBase.WorkingMasterEnum, object> wSetValue = (x, y) =>
                wDataTable.Rows[0][x.ToString()] = y?.ToString();
            wSetValue(working_date, "20180922");
            wSetValue(working_start, "0700");
            wSetValue(working_end, "2000");
            return wDataTable;
        }
    }
}
