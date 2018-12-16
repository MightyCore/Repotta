using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using static Repotta.Common.Attributes;

namespace Repotta.DBClass
{
    public abstract class DBTableBase<T> : DBBase where T : DBRowBase
    {
        #region abstracts
        public abstract List<T> RecordList { get; set; }
        #endregion abstracts

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBTableBase() { }
        #endregion コンストラクタ

        #region Query
        /// <summary>
        /// INSERT文作成
        /// </summary>
        /// <param name="vDicWhere"></param>
        /// <returns></returns>
        public string GetQueryInsert(Dictionary<Enum, object> vDicWhere = null)
        {
            string wQuery = $"INSERT INTO {DBTable} VALUES {Environment.NewLine}";
            wQuery += RecordList.Select(x => x.GetParamInsert()).Aggregate((x, y) => $"{x}, {y}");
            if ((vDicWhere?.Count ?? 0) > 0) wQuery += GetQueryWhere(vDicWhere);
            return wQuery;
        }

        /// <summary>
        /// SELECT文作成
        /// </summary>
        /// <param name="vDicWhere"></param>
        /// <returns></returns>
        public string GetQuerySelect(Dictionary<Enum, object> vDicWhere = null)
        {
            string wQuery = $"SELECT * FROM {DBTable}{Environment.NewLine}";
            if ((vDicWhere?.Count ?? 0) > 0) wQuery += GetQueryWhere(vDicWhere);
            return wQuery;
        }
        #endregion Query
    }

    public abstract class DBRowBase : DBBase
    {
        #region abstracts
        protected abstract Type DBFields { get; }
        protected abstract string GetValue(Enum vEnum);
        #endregion abstracts

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBRowBase() { }
        #endregion コンストラクタ

        #region 値取得
        /// <summary>
        /// DataRowから文字列取得
        /// </summary>
        /// <param name="vDataRow"></param>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        protected string ToString(DataRow vDataRow, Enum vEnum) =>
            ExistCol(vDataRow, vEnum) ? vDataRow[vEnum.ToString()]?.ToString() ?? "" : "";

        /// <summary>
        /// DataRowから数値取得
        /// </summary>
        /// <param name="vDataRow"></param>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        protected int ToInt(DataRow vDataRow, Enum vEnum) => ToIntOrNull(vDataRow, vEnum) ?? 0;

        /// <summary>
        /// DataRowから数値またはNull取得
        /// </summary>
        /// <param name="vDataRow"></param>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        protected int? ToIntOrNull(DataRow vDataRow, Enum vEnum) =>
            ExistCol(vDataRow, vEnum)
            ? int.TryParse(vDataRow[vEnum.ToString()].ToString(), out int wIntValue) ? wIntValue : (int?)null
            : null;

        /// <summary>
        /// 対象列が存在するか確認
        /// </summary>
        /// <param name="vDataRow"></param>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        private bool ExistCol(DataRow vDataRow, Enum vEnum) =>
            vDataRow.Table.Columns.Contains(vEnum.ToString());
        #endregion 値取得

        #region DB更新
        /// <summary>
        /// UPDATE文作成
        /// </summary>
        /// <param name="vDicWhere"></param>
        /// <returns></returns>
        public string GetQueryUpdate(Dictionary<Enum, object> vDicWhere = null)
        {
            string wQuery = $"UPDATE {DBTable}{Environment.NewLine} SET {Environment.NewLine}";
            wQuery += Enum.GetValues(DBFields).Cast<Enum>()
                .Select(x => GetParamSetter(new KeyValuePair<Enum, object>(x, GetValue(x))))
                .Aggregate((x, y) => $"{x}, {y}");
            if ((vDicWhere?.Count ?? 0) > 0) wQuery += GetQueryWhere(vDicWhere);
            return wQuery;
        }

        /// <summary>
        /// 挿入用の1レコード分のInsert文作成
        /// </summary>
        /// <returns></returns>
        public string GetParamInsert() =>
            $"({Enum.GetValues(DBFields).Cast<Enum>().Select(x => $"'{GetValue(x)}'").Aggregate((x, y) => $"{x}, {y}")}){Environment.NewLine}";
        #endregion DB更新
    }

    public abstract class DBBase
    {
        #region abstracts
        protected abstract DBTablesEnum DBTable { get; }
        #endregion abstracts

        #region Enum
        /// <summary>
        /// テーブル名称
        /// </summary>
        protected enum DBTablesEnum : int
        {
            [Text(Text = "社員マスタ")]
            EmployeeMaster = 1,
            [Text(Text = "役職マスタ")]
            PostMaster,
            [Text(Text = "会社マスタ")]
            CorpMaster,
            [Text(Text = "部署マスタ")]
            DepartmentMaster,
            [Text(Text = "客先マスタ")]
            CustomerMaster,
            [Text(Text = "基本勤怠情報マスタ")]
            DefaultInfoMaster,
            [Text(Text = "勤務マスタ")]
            WorkingMaster
        }

        /// <summary>
        /// 勤務マスタ
        /// </summary>
        public enum WorkingMasterEnum : int
        {
            [Text(Text = "年月日")]
            working_date = 1,
            [Text(Text = "社員番号")]
            employee_number,
            [Text(Text = "役職名")]
            post_name,
            [Text(Text = "会社名")]
            company_name,
            [Text(Text = "部署名")]
            department_name,
            [Text(Text = "休日フラグ")]
            holiday_flag,
            [Text(Text = "開始時間")]
            working_start,
            [Text(Text = "終了時間")]
            working_end,
            [Text(Text = "休憩時間")]
            break_time,
            [Text(Text = "自社勤務時間")]
            their_working_time,
            [Text(Text = "通常勤務時間")]
            nomal_working,
            [Text(Text = "自社業務工数")]
            their_working_number,
            [Text(Text = "客先通常勤務時間")]
            guests_nomal_working,
            [Text(Text = "客先残業勤務時間")]
            guests_over_working,
            [Text(Text = "客先合計勤務時間")]
            guests_working,
            [Text(Text = "平日時間外")]
            weekdays_over,
            [Text(Text = "平日深夜")]
            weekdays_night,
            [Text(Text = "休日時間外")]
            holiday_over,
            [Text(Text = "休日深夜")]
            holiday_night,
            [Text(Text = "休暇フラグ")]
            vacation_flag,
            [Text(Text = "休暇種別")]
            vacation_type,
            [Text(Text = "欠勤フラグ")]
            absence_flag,
            [Text(Text = "欠勤届フラグ")]
            absence_session_flag,
            [Text(Text = "遅刻・早退・私用外出フラグ")]
            late_early_out_flag,
            [Text(Text = "遅刻・早退・私用外出種別")]
            late_early_out_type,
            [Text(Text = "遅刻・早退・私用外出届フラグ")]
            late_early_out_session_type,
            [Text(Text = "遅刻・早退・私用外出時間")]
            late_early_out_time,
            [Text(Text = "備考")]
            remarks,
            [Text(Text = "登録日時")]
            update_date
        }

        /// <summary>
        /// 基本勤怠情報マスタ
        /// </summary>
        public enum DefaultInfoMaster : int
        {
            [Text(Text = "社員番号")]
            number = 1,
            [Text(Text = "客先コード")]
            name,
            [Text(Text = "勤務開始日付")]
            working_sartdate,
            [Text(Text = "勤務終了日付")]
            working_enddate,
            [Text(Text = "休日フラグ")]
            holiday_flag,
            [Text(Text = "開始時間")]
            working_start,
            [Text(Text = "終了時間")]
            working_end,
            [Text(Text = "休憩時間")]
            break_time,
            [Text(Text = "自社勤務時間")]
            their_working,
            [Text(Text = "通常勤務時間")]
            nomal_working,
            [Text(Text = "客先通常勤務時間")]
            guests_nomal_working,
            [Text(Text = "客先残業勤務時間")]
            guests_over_working,
            [Text(Text = "客先合計勤務時間")]
            guests_working,
            [Text(Text = "登録日時")]
            update_date,
            [Text(Text = "削除フラグ")]
            delete_flag
        }
        #endregion Enum

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DBBase() { }
        #endregion コンストラクタ

        /// <summary>
        /// Query実行
        /// </summary>
        /// <param name="vGetQuery"></param>
        /// <returns></returns>
        public DataTable Execute(Func<string> vGetQuery)
        {
            var wQuery = vGetQuery();
            //TODO: Query実行            
            return Repotta.Common.Util.GetDummyWorkingMaster();
        }

        #region Query
        /// <summary>
        /// WHERE区作成
        /// </summary>
        /// <param name="vDic"></param>
        /// <returns></returns>
        protected string GetQueryWhere(Dictionary<Enum, object> vDic)
        {
            if (vDic.Count == 0) return "";
            string wQuery = $"WHERE {Environment.NewLine}";
            wQuery += vDic.Select(x => GetParamSetter(x))
                      .Aggregate((x, y) => $"{x} AND {y}");
            return wQuery;
        }

        /// <summary>
        /// 値セット用数式作成
        /// </summary>
        /// <param name="vKeyVal"></param>
        /// <returns></returns>
        protected string GetParamSetter(KeyValuePair<Enum, object> vKeyVal) =>
               $"{Enum.GetName(vKeyVal.Key.GetType(), vKeyVal.Key)} = '{vKeyVal.Value?.ToString()}' {Environment.NewLine}";
        #endregion Query
    }
}
