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
    public partial class frmPwd : Form
    {
        public frmPwd()
        {
            InitializeComponent();
        }
        public bool userId;//用来接收登陆窗体的传值
        //改密确定
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sql = "";
                if (userId)
                {
                    sql = string.Format("SELECT [LoginPwd] FROM [Admin] WHERE [LoginId] = '{0}'", txtzh.Text);
                }
                else
                {
                    sql = string.Format("SELECT [LoginPwd] FROM [Student] WHERE [StudentNo] = '{0}'", txtzh.Text);
                }
                SqlCommand comm = new SqlCommand(sql, conn);
                string pwd = Convert.ToString(comm.ExecuteScalar());
                if (txtzh.Equals(String.Empty))
                {
                    MessageBox.Show("账号不能为空", "提示");
                }
                else if (txtymm.Equals(String.Empty))
                {
                    MessageBox.Show("原密码不能为空", "提示");
                }
                else if (txtxmm.Equals(String.Empty))
                {
                    MessageBox.Show("新密码不能为空", "提示");
                }
                else if (txtqrmm.Equals(String.Empty))
                {
                    MessageBox.Show("请确认密码", "提示");
                }
                else if (!(txtxmm.Text.Equals(txtqrmm.Text)))
                {
                    MessageBox.Show("两次密码输入不正确", "提示");
                }
                else if (pwd.Equals(txtymm.Text))
                {
                    if (userId)
                    {
                        string sql2 = string.Format("UPDATE [Admin] SET [LoginPwd] = '{0}' WHERE [LoginId] = '{1}'", txtxmm.Text, txtzh.Text);
                        SqlCommand comm2 = new SqlCommand(sql2, conn);
                        comm2.ExecuteNonQuery();//莫名其妙
                        MessageBox.Show("密码修改成功！");
                    }
                    else
                    {
                        string sql2 = string.Format("UPDATE [Student] SET [LoginPwd] = '{0}' WHERE [StudentNo] = '{1}'", txtxmm.Text, txtzh.Text);
                        SqlCommand comm2 = new SqlCommand(sql2, conn);
                        comm2.ExecuteNonQuery();//莫名其妙
                        MessageBox.Show("密码修改成功！");
                    }
                }
                else
                {
                    MessageBox.Show("原密码错误！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
            finally
            {
                conn.Close();//关闭连接
            }
        }
        //改密返回
        private void btnfh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
