using System;
using System.Windows.Forms;
using Repotta.DBClass;
namespace Repotta
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInputTheDayAttendance());
        }
    }
}
