using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Repotta.DBClass;
using static Repotta.DBClass.DBBase.WorkingMasterEnum;

namespace Repotta.InputTheDayAttendance
{
    public class InputTheDayAttendanceModel
    {
        #region メンバ変数
        private WorkingMasterRow FWorkingMasterRow = null;
        private DefaultInfoMasterRow FDefaultInfoMasterRow = null;
        private FormInputTheDayAttendance FForm = null;

        #region Between Form and DB
        // TODO: 画面用変数作成
        public string WorkingDate
        {
            get => FWorkingMasterRow.WorkingDate;
            set => FWorkingMasterRow.WorkingDate = value;
        }

        public string HourStart
        {
            get => string.IsNullOrEmpty(FWorkingMasterRow.WorkingStart)
                    ? FDefaultInfoMasterRow.WorkingStart.Substring(1, 2)
                    : FWorkingMasterRow.WorkingStart.Substring(1, 2);
            set => FWorkingMasterRow.WorkingStart =
                $"{value}{FWorkingMasterRow.WorkingStart.Substring(3, 2)}";
        }
        #endregion Between Form and DB
        #endregion メンバ変数

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputTheDayAttendanceModel(FormInputTheDayAttendance vForm)
        {
            FForm = vForm;
            // TODO: ini情報取得

            // TODO: ini情報、現在日付でDB情報取得
            Dictionary<Enum, object> wDicWhere = new Dictionary<Enum, object>();
            wDicWhere.Add(working_date, DateTime.Now.ToString("yyMMdd"));
            wDicWhere.Add(employee_number, "00074");
            // TODO: WorkingMasterに無ければ、基本設定から取得
            FWorkingMasterRow = new WorkingMaster(wDicWhere).RecordList.First();
            FDefaultInfoMasterRow = new DefaultInfoMaster(wDicWhere).RecordList.First();

            SetToForm();
        }
        #endregion コンストラクタ

        #region Method
        // TODO: 登録メソッド作成
        public void Execute()
        {
            SetToDB();
            FWorkingMasterRow.Execute(() => FWorkingMasterRow.GetQueryUpdate());
        }

        // TODO: チェックメソッド作成

        // TODO: 値セットメソッド作成
        private void SetToDB()
        {
            WorkingDate = FForm.dtpDate.Value.ToString("yyyyMMdd");
            // TODO: 落ちる
            //HourStart = FForm.cmbHourStart.Text;
        }

        private void SetToForm()
        {
            FForm.dtpDate.Value = DateTime.ParseExact(WorkingDate, "yyyyMMdd", null);
            // TODO: Set Combobox value
            //FForm.cmbHourStart.SelectedValue = HourStart;
        }
        #endregion Method
    }
}
