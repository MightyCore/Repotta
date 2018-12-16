using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using static Repotta.DBClass.WorkingMaster.WorkingMasterEnum;

namespace Repotta.DBClass
{
    /// <summary>
    /// 勤務マスタ
    /// </summary>
    public class WorkingMaster : DBTableBase<WorkingMasterRow>
    {
        #region overrides
        protected override DBTablesEnum DBTable => DBTablesEnum.WorkingMaster;
        public override List<WorkingMasterRow> RecordList { get; set; } = new List<WorkingMasterRow>();
        #endregion overrides

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDataTable"></param>
        public WorkingMaster(DataTable vDataTable)
        {
            RecordList = vDataTable.Rows.Cast<DataRow>().Select(x => new WorkingMasterRow(x)).ToList();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDicWhere"></param>
        public WorkingMaster(Dictionary<Enum, object> vDicWhere)
        {
            RecordList = Execute(() => GetQuerySelect(vDicWhere))?.Rows.Cast<DataRow>()
                         .Select(x => new WorkingMasterRow(x)).ToList() 
                         ?? new List<WorkingMasterRow>();
        }
        #endregion コンストラクタ
    }

    /// <summary>
    /// DBレコード
    /// </summary>
    public class WorkingMasterRow : DBRowBase
    {
        #region overrides
        protected override DBTablesEnum DBTable => DBTablesEnum.WorkingMaster;
        protected override Type DBFields => typeof(WorkingMasterEnum);
        protected override string GetValue(Enum vEnum)
        {
            switch (vEnum)
            {
                case working_date: return WorkingDate;
                case employee_number: return EmployeeNumber;
                case post_name: return PostName;
                case company_name: return CompanyName;
                case department_name: return DepartmentName;
                case holiday_flag: return HolidayFlag;
                case working_start: return WorkingStart;
                case working_end: return WorkingEnd;
                case break_time: return BreakTime.ToString();
                case their_working_time: return TheirWorkingTime.ToString();
                case nomal_working: return NomalWorking.ToString();
                case their_working_number: return TheirWorkingNumber.ToString();
                case guests_nomal_working: return GuestsNomalWorking.ToString();
                case guests_over_working: return GuestsOverWorking.ToString();
                case guests_working: return GuestsWorking.ToString();
                case weekdays_over: return WeekdaysOver?.ToString();
                case weekdays_night: return WeekdaysNight?.ToString();
                case holiday_over: return HolidayOver?.ToString();
                case holiday_night: return HolidayNight?.ToString();
                case vacation_flag: return VacationFlag?.ToString();
                case vacation_type: return VacationType?.ToString();
                case absence_flag: return AbsenceFlag?.ToString();
                case absence_session_flag: return AbsenceSessionFlag?.ToString();
                case late_early_out_flag: return LateEarlyOutFlag?.ToString();
                case late_early_out_type: return LateEarlyOutType?.ToString();
                case late_early_out_session_type: return LateEarlyOutSessionType?.ToString();
                case late_early_out_time: return LateEarlyOutTime;
                case remarks: return Remarks;
                case update_date: return UpdateDate;
                default: return "";
            }
        }
        #endregion overrides

        #region Columns
        public string WorkingDate { get; set; }
        public string EmployeeNumber { get; set; }
        public string PostName { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string HolidayFlag { get; set; }
        public string WorkingStart { get; set; }
        public string WorkingEnd { get; set; }
        public int BreakTime { get; set; }
        public int TheirWorkingTime { get; set; }
        public int NomalWorking { get; set; }
        public int TheirWorkingNumber { get; set; }
        public int GuestsNomalWorking { get; set; }
        public int GuestsOverWorking { get; set; }
        public int GuestsWorking { get; set; }
        public int? WeekdaysOver { get; set; }
        public int? WeekdaysNight { get; set; }
        public int? HolidayOver { get; set; }
        public int? HolidayNight { get; set; }
        public int? VacationFlag { get; set; }
        public int? VacationType { get; set; }
        public int? AbsenceFlag { get; set; }
        public int? AbsenceSessionFlag { get; set; }
        public int? LateEarlyOutFlag { get; set; }
        public int? LateEarlyOutType { get; set; }
        public int? LateEarlyOutSessionType { get; set; }
        public string LateEarlyOutTime { get; set; }
        public string Remarks { get; set; }
        public string UpdateDate { get; set; }
        #endregion Columns

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vDataRow"></param>
        public WorkingMasterRow(DataRow vDataRow)
        {
            WorkingDate = ToString(vDataRow, working_date);
            EmployeeNumber = ToString(vDataRow, employee_number);
            PostName = ToString(vDataRow, post_name);
            CompanyName = ToString(vDataRow, company_name);
            DepartmentName = ToString(vDataRow, department_name);
            HolidayFlag = ToString(vDataRow, holiday_flag);
            WorkingStart = ToString(vDataRow, working_start);
            WorkingEnd = ToString(vDataRow, working_end);
            BreakTime = ToInt(vDataRow, break_time);
            TheirWorkingTime = ToInt(vDataRow, their_working_time);
            NomalWorking = ToInt(vDataRow, nomal_working);
            TheirWorkingNumber = ToInt(vDataRow, their_working_number);
            GuestsNomalWorking = ToInt(vDataRow, guests_nomal_working);
            GuestsOverWorking = ToInt(vDataRow, guests_over_working);
            GuestsWorking = ToInt(vDataRow, guests_working);
            WeekdaysOver = ToIntOrNull(vDataRow, weekdays_over);
            WeekdaysNight = ToIntOrNull(vDataRow, weekdays_night);
            HolidayOver = ToIntOrNull(vDataRow, holiday_over);
            HolidayNight = ToIntOrNull(vDataRow, holiday_night);
            VacationFlag = ToIntOrNull(vDataRow, vacation_flag);
            VacationType = ToIntOrNull(vDataRow, vacation_type);
            AbsenceFlag = ToIntOrNull(vDataRow, absence_flag);
            AbsenceSessionFlag = ToIntOrNull(vDataRow, absence_session_flag);
            LateEarlyOutFlag = ToIntOrNull(vDataRow, late_early_out_flag);
            LateEarlyOutType = ToIntOrNull(vDataRow, late_early_out_type);
            LateEarlyOutSessionType = ToIntOrNull(vDataRow, late_early_out_session_type);
            LateEarlyOutTime = ToString(vDataRow, late_early_out_time);
            Remarks = ToString(vDataRow, remarks);
            UpdateDate = ToString(vDataRow, update_date);
        }
        #endregion コンストラクタ
    }
}
