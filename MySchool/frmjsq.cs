using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    public partial class frmjsq : Form
    {
        public frmjsq()
        {
            InitializeComponent();
        }

        private void lblNo4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jd3_Load(object sender, EventArgs e)
        {
            cboysf.SelectedIndex = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text != "" && txtNo2.Text != "")
            {
                if (cboysf.Text.Equals("+"))
                {
                    double qq = double.Parse(txtNo1.Text);
                    double ww = double.Parse(txtNo2.Text);
                    txtNo3.Text = Convert.ToString(qq+ww);
                }
                else if (cboysf.Text.Equals("-"))
                {
                    double qq = double.Parse(txtNo1.Text);
                    double ww = double.Parse(txtNo2.Text);
                    txtNo3.Text = Convert.ToString(qq - ww);
                }
                else if (cboysf.Text.Equals("*"))
                {
                    double qq = double.Parse(txtNo1.Text);
                    double ww = double.Parse(txtNo2.Text);
                    txtNo3.Text = Convert.ToString(qq * ww);
                }
                else if (cboysf.Text.Equals("/"))
                {
                    double qq = double.Parse(txtNo1.Text);
                    double ww = double.Parse(txtNo2.Text);
                    txtNo3.Text = Convert.ToString(qq / ww);
                }
            }
            else
            {
                MessageBox.Show("无法计算空值", "温馨提示");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭计算器
        }
    }
}
