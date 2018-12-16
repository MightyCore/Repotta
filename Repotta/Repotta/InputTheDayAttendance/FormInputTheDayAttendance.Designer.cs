namespace Repotta
{
    partial class FormInputTheDayAttendance
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbVacationType = new System.Windows.Forms.ComboBox();
            this.cmbLateEarlyOutType = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.lblHourStart = new System.Windows.Forms.Label();
            this.lblMinStart = new System.Windows.Forms.Label();
            this.lblHourEnd = new System.Windows.Forms.Label();
            this.lblMinEnd = new System.Windows.Forms.Label();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblTheirWorking = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblNormalWorking = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblBiko = new System.Windows.Forms.Label();
            this.cbVacation = new System.Windows.Forms.CheckBox();
            this.cbAbsence = new System.Windows.Forms.CheckBox();
            this.lblH4 = new System.Windows.Forms.Label();
            this.cbLateEarlyOut = new System.Windows.Forms.CheckBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.cmbAbsenceFlag = new System.Windows.Forms.ComboBox();
            this.cmbLateEarlyOutFlag = new System.Windows.Forms.ComboBox();
            this.tbLateEarlyOutTime = new System.Windows.Forms.TextBox();
            this.tbNormalWorkingTime = new System.Windows.Forms.TextBox();
            this.tbTheirWorkingTime = new System.Windows.Forms.TextBox();
            this.tbBreakTime = new System.Windows.Forms.TextBox();
            this.cmbHourStart = new System.Windows.Forms.ComboBox();
            this.cmbMinStart = new System.Windows.Forms.ComboBox();
            this.cmbHourEnd = new System.Windows.Forms.ComboBox();
            this.cmbMinEnd = new System.Windows.Forms.ComboBox();
            this.cbHoliday = new System.Windows.Forms.CheckBox();
            this.tbBiko = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbVacationType
            // 
            this.cmbVacationType.Enabled = false;
            this.cmbVacationType.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbVacationType.FormattingEnabled = true;
            this.cmbVacationType.Location = new System.Drawing.Point(106, 151);
            this.cmbVacationType.Name = "cmbVacationType";
            this.cmbVacationType.Size = new System.Drawing.Size(92, 28);
            this.cmbVacationType.TabIndex = 11;
            // 
            // cmbLateEarlyOutType
            // 
            this.cmbLateEarlyOutType.Enabled = false;
            this.cmbLateEarlyOutType.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbLateEarlyOutType.FormattingEnabled = true;
            this.cmbLateEarlyOutType.Location = new System.Drawing.Point(196, 186);
            this.cmbLateEarlyOutType.Name = "cmbLateEarlyOutType";
            this.cmbLateEarlyOutType.Size = new System.Drawing.Size(121, 28);
            this.cmbLateEarlyOutType.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 23);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "[当日勤怠入力]";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(12, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 23);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "日付";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblWorkingTime.Location = new System.Drawing.Point(12, 82);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(88, 23);
            this.lblWorkingTime.TabIndex = 24;
            this.lblWorkingTime.Text = "勤務時間";
            // 
            // lblHourStart
            // 
            this.lblHourStart.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblHourStart.Location = new System.Drawing.Point(159, 82);
            this.lblHourStart.Name = "lblHourStart";
            this.lblHourStart.Size = new System.Drawing.Size(25, 23);
            this.lblHourStart.TabIndex = 15;
            this.lblHourStart.Text = "時";
            // 
            // lblMinStart
            // 
            this.lblMinStart.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblMinStart.Location = new System.Drawing.Point(249, 82);
            this.lblMinStart.Name = "lblMinStart";
            this.lblMinStart.Size = new System.Drawing.Size(54, 23);
            this.lblMinStart.TabIndex = 14;
            this.lblMinStart.Text = "分　～";
            // 
            // lblHourEnd
            // 
            this.lblHourEnd.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblHourEnd.Location = new System.Drawing.Point(366, 81);
            this.lblHourEnd.Name = "lblHourEnd";
            this.lblHourEnd.Size = new System.Drawing.Size(25, 23);
            this.lblHourEnd.TabIndex = 13;
            this.lblHourEnd.Text = "時";
            // 
            // lblMinEnd
            // 
            this.lblMinEnd.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblMinEnd.Location = new System.Drawing.Point(450, 81);
            this.lblMinEnd.Name = "lblMinEnd";
            this.lblMinEnd.Size = new System.Drawing.Size(30, 23);
            this.lblMinEnd.TabIndex = 12;
            this.lblMinEnd.Text = "分";
            // 
            // lblBreakTime
            // 
            this.lblBreakTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblBreakTime.Location = new System.Drawing.Point(12, 117);
            this.lblBreakTime.Name = "lblBreakTime";
            this.lblBreakTime.Size = new System.Drawing.Size(100, 23);
            this.lblBreakTime.TabIndex = 22;
            this.lblBreakTime.Text = "休憩(外出)";
            // 
            // lblH1
            // 
            this.lblH1.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblH1.Location = new System.Drawing.Point(159, 117);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(25, 23);
            this.lblH1.TabIndex = 21;
            this.lblH1.Text = "h";
            // 
            // lblTheirWorking
            // 
            this.lblTheirWorking.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblTheirWorking.Location = new System.Drawing.Point(190, 117);
            this.lblTheirWorking.Name = "lblTheirWorking";
            this.lblTheirWorking.Size = new System.Drawing.Size(81, 23);
            this.lblTheirWorking.TabIndex = 17;
            this.lblTheirWorking.Text = "自社業務";
            // 
            // lblH2
            // 
            this.lblH2.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblH2.Location = new System.Drawing.Point(321, 117);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(27, 19);
            this.lblH2.TabIndex = 20;
            this.lblH2.Text = "h";
            // 
            // lblNormalWorking
            // 
            this.lblNormalWorking.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblNormalWorking.Location = new System.Drawing.Point(354, 117);
            this.lblNormalWorking.Name = "lblNormalWorking";
            this.lblNormalWorking.Size = new System.Drawing.Size(80, 23);
            this.lblNormalWorking.TabIndex = 16;
            this.lblNormalWorking.Text = "通常勤務";
            // 
            // lblH3
            // 
            this.lblH3.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblH3.Location = new System.Drawing.Point(484, 117);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(24, 23);
            this.lblH3.TabIndex = 19;
            this.lblH3.Text = "h";
            // 
            // lblBiko
            // 
            this.lblBiko.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblBiko.Location = new System.Drawing.Point(12, 224);
            this.lblBiko.Name = "lblBiko";
            this.lblBiko.Size = new System.Drawing.Size(65, 23);
            this.lblBiko.TabIndex = 23;
            this.lblBiko.Text = "備考";
            // 
            // cbVacation
            // 
            this.cbVacation.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cbVacation.Location = new System.Drawing.Point(16, 152);
            this.cbVacation.Name = "cbVacation";
            this.cbVacation.Size = new System.Drawing.Size(71, 24);
            this.cbVacation.TabIndex = 10;
            this.cbVacation.Text = "休暇";
            this.cbVacation.UseVisualStyleBackColor = true;
            this.cbVacation.CheckedChanged += new System.EventHandler(this.cbVacation_CheckedChanged);
            // 
            // cbAbsence
            // 
            this.cbAbsence.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cbAbsence.Location = new System.Drawing.Point(208, 153);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new System.Drawing.Size(63, 24);
            this.cbAbsence.TabIndex = 12;
            this.cbAbsence.Text = "欠勤";
            this.cbAbsence.UseVisualStyleBackColor = true;
            this.cbAbsence.CheckedChanged += new System.EventHandler(this.cbAbsence_CheckedChanged);
            // 
            // lblH4
            // 
            this.lblH4.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lblH4.Location = new System.Drawing.Point(418, 189);
            this.lblH4.Name = "lblH4";
            this.lblH4.Size = new System.Drawing.Size(31, 23);
            this.lblH4.TabIndex = 18;
            this.lblH4.Text = "h";
            // 
            // cbLateEarlyOut
            // 
            this.cbLateEarlyOut.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cbLateEarlyOut.Location = new System.Drawing.Point(16, 188);
            this.cbLateEarlyOut.Name = "cbLateEarlyOut";
            this.cbLateEarlyOut.Size = new System.Drawing.Size(168, 24);
            this.cbLateEarlyOut.TabIndex = 14;
            this.cbLateEarlyOut.Text = "遅刻・早退・私用外出";
            this.cbLateEarlyOut.UseVisualStyleBackColor = true;
            this.cbLateEarlyOut.CheckedChanged += new System.EventHandler(this.cbLateEarlyOut_CheckedChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.btnMenu.Location = new System.Drawing.Point(16, 260);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 29);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "メニュー";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.btnRegist.Location = new System.Drawing.Point(433, 260);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 29);
            this.btnRegist.TabIndex = 20;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // cmbAbsenceFlag
            // 
            this.cmbAbsenceFlag.Enabled = false;
            this.cmbAbsenceFlag.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbAbsenceFlag.FormattingEnabled = true;
            this.cmbAbsenceFlag.Location = new System.Drawing.Point(277, 150);
            this.cmbAbsenceFlag.Name = "cmbAbsenceFlag";
            this.cmbAbsenceFlag.Size = new System.Drawing.Size(45, 28);
            this.cmbAbsenceFlag.TabIndex = 13;
            // 
            // cmbLateEarlyOutFlag
            // 
            this.cmbLateEarlyOutFlag.Enabled = false;
            this.cmbLateEarlyOutFlag.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbLateEarlyOutFlag.FormattingEnabled = true;
            this.cmbLateEarlyOutFlag.Location = new System.Drawing.Point(325, 186);
            this.cmbLateEarlyOutFlag.Name = "cmbLateEarlyOutFlag";
            this.cmbLateEarlyOutFlag.Size = new System.Drawing.Size(43, 28);
            this.cmbLateEarlyOutFlag.TabIndex = 16;
            // 
            // tbLateEarlyOutTime
            // 
            this.tbLateEarlyOutTime.Enabled = false;
            this.tbLateEarlyOutTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.tbLateEarlyOutTime.Location = new System.Drawing.Point(374, 186);
            this.tbLateEarlyOutTime.MaxLength = 2;
            this.tbLateEarlyOutTime.Name = "tbLateEarlyOutTime";
            this.tbLateEarlyOutTime.Size = new System.Drawing.Size(38, 28);
            this.tbLateEarlyOutTime.TabIndex = 17;
            // 
            // tbNormalWorkingTime
            // 
            this.tbNormalWorkingTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.tbNormalWorkingTime.Location = new System.Drawing.Point(440, 114);
            this.tbNormalWorkingTime.MaxLength = 2;
            this.tbNormalWorkingTime.Name = "tbNormalWorkingTime";
            this.tbNormalWorkingTime.Size = new System.Drawing.Size(38, 28);
            this.tbNormalWorkingTime.TabIndex = 9;
            // 
            // tbTheirWorkingTime
            // 
            this.tbTheirWorkingTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.tbTheirWorkingTime.Location = new System.Drawing.Point(277, 114);
            this.tbTheirWorkingTime.MaxLength = 2;
            this.tbTheirWorkingTime.Name = "tbTheirWorkingTime";
            this.tbTheirWorkingTime.Size = new System.Drawing.Size(38, 28);
            this.tbTheirWorkingTime.TabIndex = 8;
            // 
            // tbBreakTime
            // 
            this.tbBreakTime.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.tbBreakTime.Location = new System.Drawing.Point(106, 114);
            this.tbBreakTime.MaxLength = 2;
            this.tbBreakTime.Name = "tbBreakTime";
            this.tbBreakTime.Size = new System.Drawing.Size(45, 28);
            this.tbBreakTime.TabIndex = 7;
            // 
            // cmbHourStart
            // 
            this.cmbHourStart.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbHourStart.FormattingEnabled = true;
            this.cmbHourStart.Location = new System.Drawing.Point(106, 78);
            this.cmbHourStart.MaxLength = 2;
            this.cmbHourStart.Name = "cmbHourStart";
            this.cmbHourStart.Size = new System.Drawing.Size(45, 28);
            this.cmbHourStart.TabIndex = 3;
            this.cmbHourStart.Text = "08";
            // 
            // cmbMinStart
            // 
            this.cmbMinStart.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbMinStart.FormattingEnabled = true;
            this.cmbMinStart.Location = new System.Drawing.Point(196, 78);
            this.cmbMinStart.MaxLength = 2;
            this.cmbMinStart.Name = "cmbMinStart";
            this.cmbMinStart.Size = new System.Drawing.Size(45, 28);
            this.cmbMinStart.TabIndex = 4;
            this.cmbMinStart.Text = "00";
            // 
            // cmbHourEnd
            // 
            this.cmbHourEnd.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbHourEnd.FormattingEnabled = true;
            this.cmbHourEnd.Location = new System.Drawing.Point(313, 78);
            this.cmbHourEnd.MaxLength = 2;
            this.cmbHourEnd.Name = "cmbHourEnd";
            this.cmbHourEnd.Size = new System.Drawing.Size(45, 28);
            this.cmbHourEnd.TabIndex = 5;
            this.cmbHourEnd.Text = "17";
            // 
            // cmbMinEnd
            // 
            this.cmbMinEnd.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cmbMinEnd.FormattingEnabled = true;
            this.cmbMinEnd.Location = new System.Drawing.Point(398, 78);
            this.cmbMinEnd.MaxLength = 2;
            this.cmbMinEnd.Name = "cmbMinEnd";
            this.cmbMinEnd.Size = new System.Drawing.Size(45, 28);
            this.cmbMinEnd.TabIndex = 6;
            this.cmbMinEnd.Text = "00";
            // 
            // cbHoliday
            // 
            this.cbHoliday.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.cbHoliday.Location = new System.Drawing.Point(279, 46);
            this.cbHoliday.Name = "cbHoliday";
            this.cbHoliday.Size = new System.Drawing.Size(71, 24);
            this.cbHoliday.TabIndex = 2;
            this.cbHoliday.Text = "休日";
            this.cbHoliday.UseVisualStyleBackColor = true;
            // 
            // tbBiko
            // 
            this.tbBiko.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.tbBiko.Location = new System.Drawing.Point(69, 221);
            this.tbBiko.MaxLength = 256;
            this.tbBiko.Name = "tbBiko";
            this.tbBiko.Size = new System.Drawing.Size(439, 28);
            this.tbBiko.TabIndex = 18;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Meiryo UI", 12F);
            this.dtpDate.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.dtpDate.Location = new System.Drawing.Point(71, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 28);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2018, 11, 25, 20, 16, 9, 0);
            // 
            // FormInputTheDayAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 301);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbBreakTime);
            this.Controls.Add(this.tbBiko);
            this.Controls.Add(this.tbTheirWorkingTime);
            this.Controls.Add(this.tbNormalWorkingTime);
            this.Controls.Add(this.tbLateEarlyOutTime);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbHoliday);
            this.Controls.Add(this.cbAbsence);
            this.Controls.Add(this.cbLateEarlyOut);
            this.Controls.Add(this.cbVacation);
            this.Controls.Add(this.lblMinEnd);
            this.Controls.Add(this.lblHourEnd);
            this.Controls.Add(this.lblMinStart);
            this.Controls.Add(this.lblHourStart);
            this.Controls.Add(this.lblNormalWorking);
            this.Controls.Add(this.lblTheirWorking);
            this.Controls.Add(this.lblH4);
            this.Controls.Add(this.lblH3);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblBreakTime);
            this.Controls.Add(this.lblBiko);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbLateEarlyOutFlag);
            this.Controls.Add(this.cmbMinEnd);
            this.Controls.Add(this.cmbHourEnd);
            this.Controls.Add(this.cmbMinStart);
            this.Controls.Add(this.cmbHourStart);
            this.Controls.Add(this.cmbAbsenceFlag);
            this.Controls.Add(this.cmbLateEarlyOutType);
            this.Controls.Add(this.cmbVacationType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInputTheDayAttendance";
            this.Text = "Repotta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbVacationType;
        public System.Windows.Forms.ComboBox cmbLateEarlyOutType;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblWorkingTime;
        public System.Windows.Forms.Label lblHourStart;
        public System.Windows.Forms.Label lblMinStart;
        public System.Windows.Forms.Label lblHourEnd;
        public System.Windows.Forms.Label lblMinEnd;
        public System.Windows.Forms.Label lblBreakTime;
        public System.Windows.Forms.Label lblH1;
        public System.Windows.Forms.Label lblTheirWorking;
        public System.Windows.Forms.Label lblH2;
        public System.Windows.Forms.Label lblNormalWorking;
        public System.Windows.Forms.Label lblH3;
        public System.Windows.Forms.Label lblBiko;
        public System.Windows.Forms.CheckBox cbVacation;
        public System.Windows.Forms.CheckBox cbAbsence;
        public System.Windows.Forms.Label lblH4;
        public System.Windows.Forms.CheckBox cbLateEarlyOut;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnRegist;
        public System.Windows.Forms.ComboBox cmbAbsenceFlag;
        public System.Windows.Forms.ComboBox cmbLateEarlyOutFlag;
        public System.Windows.Forms.TextBox tbLateEarlyOutTime;
        public System.Windows.Forms.TextBox tbNormalWorkingTime;
        public System.Windows.Forms.TextBox tbTheirWorkingTime;
        public System.Windows.Forms.TextBox tbBreakTime;
        public System.Windows.Forms.ComboBox cmbHourStart;
        public System.Windows.Forms.ComboBox cmbMinStart;
        public System.Windows.Forms.ComboBox cmbHourEnd;
        public System.Windows.Forms.ComboBox cmbMinEnd;
        public System.Windows.Forms.CheckBox cbHoliday;
        public System.Windows.Forms.TextBox tbBiko;
        public System.Windows.Forms.DateTimePicker dtpDate;
    }
}

