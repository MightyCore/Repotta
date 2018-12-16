using static Repotta.Common.Attributes;

namespace Repotta.Common
{
    public static class Define
    {
        #region Enum
        /// <summary>
        /// 休暇種別
        /// </summary>
        public enum VacationTypeEnum : int
        {
            [Text(Text = "")]
            Unknown = 0,
            [Text(Text = "夏季")]
            SummerVacation,
            [Text(Text = "有給")]
            FullDayOff,
            [Text(Text = "半休")]
            HalfDayOff,
            [Text(Text = "代休")]
            Daikyu,
            [Text(Text = "生理")]
            Seiri,
            [Text(Text = "慶弔")]
            KeiCho,
            [Text(Text = "特別")]
            Special
        }

        /// <summary>
        /// 遅刻・早退・私用外出
        /// </summary>
        public enum LateEarlyOutTypeEnum : int
        {
            [Text(Text = "遅刻")]
            Late = 1,
            [Text(Text = "早退")]
            LeaveEarly,
            [Text(Text = "私用外出")]
            Out
        }

        /// <summary>
        /// 届出有無
        /// </summary>
        public enum NotificationEnum : int
        {
            [Text(Text = "")]
            Unknown = 0,
            [Text(Text = "届")]
            Yes,
            [Text(Text = "無")]
            No
        }

        /// <summary>
        /// 時間用値
        /// </summary>
        public enum TimeEnum : int
        {
            MaxHour = 24,
            MaxMin = 60
        }
        #endregion Enum
    }
}
