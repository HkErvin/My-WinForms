using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;//解决父窗体控件遮盖子控件

namespace MySchool
{
    public partial class rtbMain : Form
    {
        public rtbMain()
        {
            InitializeComponent();
        }
        public string userId;//（用户名），用来接收登陆窗体的传值
        public bool userId2;//用来接收登陆窗体的传值
        //窗体加载事件
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            frmLogin skr = new frmLogin();
            this.Text = "欢迎登陆Viper、当前用户：" + userId;
        }
        //切换账号
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏现在这个窗口
            frmLogin fam = new frmLogin();
            fam.Show();
        }
        //显示学员
        private void btnStudent_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            frmLogin boss = new frmLogin();
            boss.lj();
            string sql = "SELECT [StudentNo],[StudentName],[Sex] FROM Student";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = comm.ExecuteReader();
            StringBuilder qq = new StringBuilder();
            while (reader.Read())
            {
                qq.AppendFormat("学号：{0}\t\t姓名：{1}\t\t性别：{2}\n", reader["StudentNo"], reader["StudentName"], reader["Sex"]);
            }
            tb1.Text = qq.ToString();
            conn.Close();//关闭数据库连接
        }
        //简答2
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmyx jd = new frmyx();
            jd.Show();//打开简答2
        }
        //简答3
        private void jd3_Click(object sender, EventArgs e)
        {
            frmjsq jd = new frmjsq();
            jd.Show();//打开简答3
        }
        //简答4
        private void btnrq_Click(object sender, EventArgs e)
        {
            frmrq jd = new frmrq();
            jd.Show();//打开简答4
        }
        //简答5
        private void btncs_Click(object sender, EventArgs e)
        {
            frmcs jd = new frmcs();
            jd.Show();//打开简答5
        }
        //修改密码
        private void btngm_Click(object sender, EventArgs e)
        {
            //frmPwd pwd = new frmPwd();
            frmPwd b = new frmPwd();
            b.userId = userId2;
            b.Show();//打开修改密码界面
        }
        //窗口关闭事件
        private void rtbMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);//结束整个程序
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出整个程序
        }
        [DllImport("user32")]//解决父窗体控件遮盖子控件
        public static extern int SetParent(int hWndChild, int hWndNewParent);//解决父窗体控件遮盖子控件
        //打开新增学生窗口
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentAdm xz = new frmStudentAdm();
            xz.MdiParent = this;
            xz.Show();//打开新增学生窗口
            SetParent((int)xz.Handle, (int)this.Handle);//解决父窗体控件遮盖子控件
        }

        private void tsmiHellp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("帮个jb，有问题自己解决！", "警告");
        }
        //QQ单机事件
        private void btnQQ_Click(object sender, EventArgs e)
        {
            frmQQ qq = new frmQQ();
            qq.MdiParent = this;
            qq.Show();//打开QQ窗口
            SetParent((int)qq.Handle, (int)this.Handle);//解决父窗体控件遮盖子控件
        }
        //学生信息查询
        private void tsmiStudentQuery_Click(object sender, EventArgs e)
        {
            frmQueryStudent st = new frmQueryStudent();
            st.MdiParent = this;
            st.Show();//打开新增学生窗口
            SetParent((int)st.Handle, (int)this.Handle);//解决父窗体控件遮盖子控件
        }
    }
}
