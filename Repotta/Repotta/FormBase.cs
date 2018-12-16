using System;
using System.Linq;
using System.Windows.Forms;
using static Repotta.Common.Attributes;

namespace Repotta
{
    public class FormBase : Form
    {
        #region ComboBox
        /// <summary>
        /// コンボボックス項目設定
        /// </summary>
        /// <param name="vComboBox"></param>
        /// <param name="vType"></param>
        /// <param name="vSkip"></param>
        protected void SetComboBox(ComboBox vComboBox, Type vType, Enum[] vSkip = null)
        {
            foreach (Enum wEnum in Enum.GetValues(vType))
            {
                if (vSkip?.Contains(wEnum) ?? false) continue;
                vComboBox.Items.Add(wEnum.GetText());
            }
        }

        /// <summary>
        /// コンボボックス値設定
        /// </summary>
        /// <param name="vComboBox"></param>
        /// <param name="vMax"></param>
        /// <param name="vMin"></param>
        protected void SetComboBox(ComboBox vComboBox, int vMax, int vMin = 0)
        {
            for (int i = vMin; i < vMax; i++)
            {
                vComboBox.Items.Add(i.ToString().PadLeft(vComboBox.MaxLength, '0'));
            }
        }

        /// <summary>
        /// コンボボックス初期設定
        /// </summary>
        /// <param name="vComboBox"></param>
        protected void SetComboBox(ComboBox vComboBox, Action<ComboBox> vSetCombobox)
        {
            vComboBox.Items.Clear();
            vComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vSetCombobox(vComboBox);
            vComboBox.SelectedIndex = 0;
        }
        #endregion ComboBox
    }
}
