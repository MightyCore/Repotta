using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Repotta.InputTheDayAttendance;
using static Repotta.Common.Define;

namespace Repotta
{
    public partial class FormInputTheDayAttendance : FormBase
    {
        #region メンバ変数
        private InputTheDayAttendanceModel FModel = null;
        #endregion メンバ変数

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormInputTheDayAttendance()
        {
            InitializeComponent();
            SetSetting();
        }
        #endregion コンストラクタ

        #region プロパティ
        /// <summary>
        /// フォーム画面設定
        /// </summary>
        private void SetSetting()
        {
            SetComboBox(this.cmbVacationType, x => SetComboBox(x, typeof(VacationTypeEnum), new Enum[] { VacationTypeEnum.Unknown }));
            SetComboBox(this.cmbLateEarlyOutType, x => SetComboBox(x, typeof(LateEarlyOutTypeEnum)));
            SetComboBox(this.cmbAbsenceFlag, x => SetComboBox(x, typeof(NotificationEnum)));
            SetComboBox(this.cmbLateEarlyOutFlag, x => SetComboBox(x, typeof(NotificationEnum)));
            SetComboBox(this.cmbHourStart, x => SetComboBox(x, (int)TimeEnum.MaxHour));
            SetComboBox(this.cmbMinStart, x => SetComboBox(x, (int)TimeEnum.MaxMin));
            SetComboBox(this.cmbHourEnd, x => SetComboBox(x, (int)TimeEnum.MaxHour));
            SetComboBox(this.cmbMinEnd, x => SetComboBox(x, (int)TimeEnum.MaxMin));

            // TODO: DBの情報を反映
            FModel = new InputTheDayAttendanceModel(this);
        }
        #endregion プロパティ

        #region イベント
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // TODO: Menu画面へ遷移処理に変更
            MessageBox.Show("メニューがありません。");
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "登録しても宜しいですか？", "登録", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                // TODO: 登録処理追記
                FModel.Execute();
            }
            catch (Exception exp)
            {
                // TODO: エラーメッセージ表示
            }

            MessageBox.Show("登録が完了しました。");
        }

        private void cbVacation_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbVacationType.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbAbsence_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbAbsenceFlag.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbLateEarlyOut_CheckedChanged(object sender, EventArgs e)
        {
            cmbLateEarlyOutType.Enabled =
            cmbLateEarlyOutFlag.Enabled =
            tbLateEarlyOutTime.Enabled = ((CheckBox)sender).Checked;
        }

        // TODO: チェック時動作を画面情報を加味した動きに変更

        // TODO: 日付変更時の画面更新
        #endregion イベント
    }
}
