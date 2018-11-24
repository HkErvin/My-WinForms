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
    public partial class frmcs : Form
    {
        int sjs = 0;//随机数
        public frmcs()
        {
            InitializeComponent();
        }

        private void lblcs_Click(object sender, EventArgs e)
        {

        }

        private void txtcs_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void jd5_Load(object sender, EventArgs e)
        {

        }

        private void txtcs_TextChanged(object sender, EventArgs e)
        {
            if (txtcs.Text.Length > 0)
            {
                btnNo2.Enabled = true;
            }
            else if (txtcs.Text.Equals(String.Empty))
            {
                btnNo2.Enabled = false;
            }
        }
        int i = 0;
        //新游戏按钮
        private void btnNo1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            sjs = r.Next(1, 101);//返回一个1~100的数（包含1但不包含101）
            i = 0;
        }
        //猜数按钮
        private void btnNo2_Click(object sender, EventArgs e)
        {
            if (sjs == 0)
            {
                MessageBox.Show("点击新游戏开始游戏！","提示");
            }
            else if (int.Parse(txtcs.Text) > sjs)
            {
                i++;
                MessageBox.Show("大了，再猜！", "提示");
            }
            else if (int.Parse(txtcs.Text) < sjs)
            {
                i++;
                MessageBox.Show("小了，再猜！", "提示");
            }
            else if (int.Parse(txtcs.Text) == sjs)
            {
                i++;
                MessageBox.Show("猜对了，猜了" + i + "次", "提示");
                i = 0;
                sjs = 0;
            }
        }
    }
}
