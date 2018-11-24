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
    public partial class frmrq : Form
    {
        public frmrq()
        {
            InitializeComponent();
        }

        private void lblNo1_Click(object sender, EventArgs e)
        {

        }

        private void lblNo2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (int.Parse(cbo1.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    cbo2.Items.Clear();
                    for (int i = 1; i <= 31; i++ )
                    {
                        cbo2.Items.Add(i);
                    }
                    break;
                case 2:
                    cbo2.Items.Clear();
                    for (int i = 1; i <= 29; i++ )
                    {
                        cbo2.Items.Add(i);
                    }
                    break;
                default:
                    cbo2.Items.Clear();
                    for (int i = 1; i <= 30; i++ )
                    {
                        cbo2.Items.Add(i);
                    }
                    break;
            }
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jd4_Load(object sender, EventArgs e)
        {
            cbo1.SelectedIndex = 0;
            cbo2.SelectedIndex = 0;
        }
    }
}
