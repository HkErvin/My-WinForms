using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //连接数据库方法
        public void lj()
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
        }
        public const string CAPTON = "温馨提示";
        //窗体加载事件（默认选中QQ登陆）
        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
        }
        //非空验证方法
        public bool CheckInput()
        {
            if (this.txtUserName.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("必须输入用户名", CAPTON);
                txtUserName.Focus();//设置焦点
                return false;
            }
            else if (this.txtPwd.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("必须输入密码", CAPTON);//mbox消息框快捷键
                txtPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
        //登陆按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckInput())
            {
                //用户验证
                string name = txtUserName.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                string sql = "";
                string sql2 = "";
                if (cboType.Text.Equals("Student"))
                {
                    sql = string.Format("SELECT COUNT(*) FROM [Student] WHERE StudentNo='{0}' and LoginPwd='{1}'", name, pwd);
                    sql2 = string.Format("SELECT [StudentName] FROM [Student] WHERE StudentNo='{0}' and LoginPwd='{1}'", name, pwd);
                }
                else
                {
                    sql = string.Format("select COUNT(*) from admin where LoginId='{0}' and LoginPwd='{1}'", name, pwd);
                }
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();//打开连接
                    SqlCommand com = new SqlCommand(sql, conn);//执行命令的对象
                    SqlCommand comm = new SqlCommand(sql2, conn);//学生登陆显示要显示的用户名
                    int i = Convert.ToInt32(com.ExecuteScalar());
                    if (i >= 1)
                    {
                        MessageBox.Show("登陆成功", "Login");
                        //实例化主窗体对象
                        rtbMain fam = new rtbMain();
                        if (cboType.Text.Equals("Student"))
                        {
                            fam.userId = Convert.ToString(comm.ExecuteScalar());//传递学生姓名到主窗体中（学生姓名而非学号）
                            fam.userId2 = false;
                        }
                        else
                        {
                            fam.userId = txtUserName.Text.Trim();//传递登陆用户名到主窗体中（管理员）
                            fam.userId2 = true;
                        }
                        this.Hide();//隐藏现在这个窗口
                        fam.Show();//显示主窗体
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", CAPTON);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, CAPTON);
                }
                finally
                {
                    conn.Close();//关闭连接
                }
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", CAPTON, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                System.Environment.Exit(0);//结束整个程序
            }
            /*
             1.this.Close();    只是关闭当前窗口，若不是主窗体的话，是无法退出程序的，另外若有托管线程（非主线程），也无法干净地退出； 

             2.Application.Exit();  强制所有消息中止，退出所有的窗体，但是若有托管线程（非主线程），也无法干净地退出； 

             3.Application.ExitThread();    强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题； 

             4.System.Environment.Exit(0);   这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
             */
        }
        //登陆窗体单击事件
        private void frmLogin_Click(object sender, EventArgs e)
        {
            if (lblViper.ForeColor == Color.White)
            {
                lblViper.ForeColor = Color.OrangeRed;
            }
            else if (lblViper.ForeColor == Color.OrangeRed)
            {
                lblViper.ForeColor = Color.Chartreuse;
            }
            else if (lblViper.ForeColor == Color.Chartreuse)
            {
                lblViper.ForeColor = Color.Cyan;
            }
            else if (lblViper.ForeColor == Color.Cyan)
            {
                lblViper.ForeColor = Color.DodgerBlue;
            }
            else if (lblViper.ForeColor == Color.DodgerBlue)
            {
                lblViper.ForeColor = Color.DarkGray;
            }
            else if (lblViper.ForeColor == Color.DarkGray)
            {
                lblViper.ForeColor = Color.OldLace;
            }
            else if (lblViper.ForeColor == Color.OldLace)
            {
                lblViper.ForeColor = Color.White;
            }
        }
    }
}
