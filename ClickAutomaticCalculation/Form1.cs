using Sunny.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClickAutomaticCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uibtSumit_Click(object sender, EventArgs e)
        {
            int sum = 0;

            // 遍历所有复选框，判断是否选中，并将选中的数字相加
            for (int i = 1; i <= 30; i++)
            {
                UICheckBox checkBox = Controls.Find("uiCheckBox" + i.ToString(), true).FirstOrDefault() as UICheckBox;
                if (checkBox != null && checkBox.Checked)
                {
                    sum += int.Parse(checkBox.Text);
                }
            }

            // 显示合计结果
            uitxtSum.Text = sum.ToString();
        }

        private void uibtSelectedAll_Click(object sender, EventArgs e)
        {
            // 遍历所有的UICheckBox并将它们的Checked属性设置为true
            foreach (Control control in this.Controls)
            {
                if(control is UICheckBox)
                {
                    UICheckBox checkBox = control as UICheckBox;
                    checkBox.Checked = true;
                }
            }
        }

        private void uibtCancelAll_Click(object sender, EventArgs e)
        {
            // 遍历所有的UICheckBox并将它们的Checked属性设置为false
            foreach (Control control in this.Controls)
            {
                if(control is UICheckBox)
                {
                    UICheckBox checkBox = control as UICheckBox;
                    checkBox.Checked = false;
                }
            }
        }
    }
}
