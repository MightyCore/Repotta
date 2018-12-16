using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using static Repotta.DBClass.DefaultInfoMaster.DefaultInfoMaster;

namespace Repotta.DBClass
{
    /// <summary>
    /// 勤務マスタ
    /// </summary>
    public class DefaultInfoMaster : DBTableBase<DefaultInfoMasterRow>
    {
        #region overrides
        protected override DBTablesEnum DBTable => DBTablesEnum.DefaultInfoMaster;
        public override List<DefaultInfoMasterRow> RecordList { get; set; } = new List<DefaultInfoMasterRow>();
        #endregion overrides

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDataTable"></param>
        public DefaultInfoMaster(DataTable vDataTable)
        {
            RecordList = vDataTable.Rows.Cast<DataRow>().Select(x => new DefaultInfoMasterRow(x)).ToList();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDicWhere"></param>
        public DefaultInfoMaster(Dictionary<Enum, object> vDicWhere)
        {
            RecordList = Execute(() => GetQuerySelect(vDicWhere))?.Rows.Cast<DataRow>().Select(x => new DefaultInfoMasterRow(x)).ToList() ?? new List<DefaultInfoMasterRow>();
        }
        #endregion コンストラクタ
    }

    /// <summary>
    /// DBレコード
    /// </summary>
    public class DefaultInfoMasterRow : DBRowBase
    {
        #region overrides
        protected override DBTablesEnum DBTable => DBTablesEnum.DefaultInfoMaster;
        protected override Type DBFields => typeof(DefaultInfoMaster);
        protected override string GetValue(Enum vEnum)
        {
            switch (vEnum)
            {
                case number: return Number;
                case name: return Name;
                case working_sartdate: return WorkingSartdate;
                case working_enddate: return WorkingEnddate;
                case holiday_flag: return HolidayFlag.ToString();
                case working_start: return WorkingStart;
                case working_end: return WorkingEnd;
                case break_time: return BreakTime.ToString();
                case their_working: return TheirWorking.ToString();
                case nomal_working: return NomalWorking.ToString();
                case guests_nomal_working: return GuestsNomalWorking.ToString();
                case guests_over_working: return GuestsOverWorking.ToString();
                case guests_working: return GuestsWorking.ToString();
                case update_date: return UpdateDate;
                case delete_flag: return DeleteFlag?.ToString();
                default: return "";
            }
        }
        #endregion overrides

        #region Columns
        public string Number { get; set; }
        public string Name { get; set; }
        public string WorkingSartdate { get; set; }
        public string WorkingEnddate { get; set; }
        public int HolidayFlag { get; set; }
        public string WorkingStart { get; set; }
        public string WorkingEnd { get; set; }
        public int BreakTime { get; set; }
        public int TheirWorking { get; set; }
        public int NomalWorking { get; set; }
        public int GuestsNomalWorking { get; set; }
        public int GuestsOverWorking { get; set; }
        public int GuestsWorking { get; set; }
        public string UpdateDate { get; set; }
        public int? DeleteFlag { get; set; }
        #endregion Columns

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDataRow"></param>
        public DefaultInfoMasterRow(DataRow vDataRow)
        {
            Number = ToString(vDataRow, number);
            Name = ToString(vDataRow, name);
            WorkingSartdate = ToString(vDataRow, working_sartdate);
            WorkingEnddate = ToString(vDataRow, working_enddate);
            HolidayFlag = ToInt(vDataRow, holiday_flag);
            WorkingStart = ToString(vDataRow, working_start);
            WorkingEnd = ToString(vDataRow, working_end);
            BreakTime = ToInt(vDataRow, break_time);
            TheirWorking = ToInt(vDataRow, their_working);
            NomalWorking = ToInt(vDataRow, nomal_working);
            GuestsNomalWorking = ToInt(vDataRow, guests_nomal_working);
            GuestsOverWorking = ToInt(vDataRow, guests_over_working);
            GuestsWorking = ToInt(vDataRow, guests_working);
            UpdateDate = ToString(vDataRow, update_date);
            DeleteFlag = ToIntOrNull(vDataRow, delete_flag);
        }
        #endregion コンストラクタ
    }
}
