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
    public partial class frmQQ : Form
    {
        public frmQQ()
        {
            InitializeComponent();
        }
        //设置大图标效果
        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvQQ.View = View.LargeIcon;
        }
        //设置小图标效果
        private void tsmiSmall_Click(object sender, EventArgs e)
        {
            this.lvQQ.View = View.SmallIcon;
        }
        //设置详细信息效果
        private void tsmiDetials_Click(object sender, EventArgs e)
        {
            this.lvQQ.View = View.Details;
        }
        //窗体加载事件
        private void frmQQ_Load(object sender, EventArgs e)
        {
            ListViewItem lvi1 = new ListViewItem();//实例化列表项
            lvi1.Text = "小明";//文本，第一项
            lvi1.ImageIndex = 0;//图片下标
            lvi1.SubItems.Add("232133");//设置项的子项
            lvi1.SubItems.Add("20");
            lvi1.SubItems.Add("男");
            this.lvQQ.Items.Add(lvi1);//把项添加到项的集合中+

            //方法二添加数据
            ListViewItem lvi2 = new ListViewItem("小强",1);
            string[] strs = new string[] { "2333444", "23", "男" };//字符串数组
            lvi2.SubItems.AddRange(strs);//添加子项数据
            this.lvQQ.Items.Add(lvi2);
        }
    }
}
