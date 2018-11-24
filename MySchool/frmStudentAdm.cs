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
    public partial class frmStudentAdm : Form
    {
        public frmStudentAdm()
        {
            InitializeComponent();
        }
        //取消
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();//关闭当前窗口
            }
        }
        //窗体加载事件
        private void frmStudentAdm_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = "SELECT [GradeName] FROM [Grade]";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = comm.ExecuteReader();
            StringBuilder qq = new StringBuilder();
            while (reader.Read())
            {
                qq.Length = 0;
                qq.AppendFormat("{0}", reader["GradeName"]);
                cboGrade.Items.Add(qq.ToString());
            }
            cboGrade.SelectedIndex = 0;//默认选中第一个选项
            conn.Close();//关闭数据库连接
        }
        //单击确定事件
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim().Equals(string.Empty) || txtPwd.Text.Trim().Equals(string.Empty) || txtPwdok.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请填写完整的注册信息", "提示");
            }
            else if (txtName.Text.Trim().Equals(string.Empty) || txtPhone.Text.Trim().Equals(string.Empty) || cboGrade.Text.Equals("请选择"))
            {
                MessageBox.Show("基本信息不全", "提示");
            }
            else
            {
                if (txtPwd.Text.Equals(txtPwdok.Text))
                {
                    if (txtPwd.TextLength < 6)
                    {
                        MessageBox.Show("密码长度不可小于6位数");
                    }
                    else if (txtEmail.Text.IndexOf("@") > 0 && txtEmail.Text.IndexOf("@") < txtEmail.Text.Length - 1)
                    {
                        if (txtPhone.Text.Length == 11)
                        {
                            string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
                            SqlConnection conn = new SqlConnection(connString);
                            try
                            {
                                conn.Open();//连接数据库
                                string grade = "";
                                switch (cboGrade.Text)
                                {
                                    case "S1":
                                        grade = "1";
                                        break;
                                    case "S2":
                                        grade = "2";
                                        break;
                                    case "Y2":
                                        grade = "3";
                                        break;
                                }
                                string Sex = "";
                                if (rbtnBoy.Checked)
                                {
                                    Sex = "男";
                                }
                                else Sex = "女";
                                string qwer = dtpDate.Text;
                                //修改字符串
                                string newqwer = qwer.Replace('年', '-');
                                string newqwer1 = newqwer.Replace('月', '-');
                                string newqwer2 = newqwer1.Replace('日', ' ');
                                String sql = string.Format(@"INSERT INTO [Student] ([StudentNo],[LoginPwd],[StudentName],
                                    [Phone],[BornDate],[Address],[Email],[Sex],[GradeId]) VALUES ('{0}','{1}','{2}','{3}'
                                    ,'{4}','{5}','{6}','{7}',{8})", txtNumber.Text, txtPwd.Text, txtName.Text, txtPhone.Text,
                                newqwer2, txtAddress.Text, txtEmail.Text, Sex, grade);
                                SqlCommand comm = new SqlCommand(sql, conn);
                                int hs = comm.ExecuteNonQuery();//执行语句并返回受影响的行数
                                if (hs < 1)
                                {
                                    MessageBox.Show("修改失败", "提示");
                                }
                                else MessageBox.Show("修改成功！", "提示");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "异常");
                                MessageBox.Show(txtEmail.Text);
                            }
                            finally
                            {
                                conn.Close();//关闭数据库连接
                            }

                        }
                        else
                        {
                            MessageBox.Show("电话格式错误！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("邮箱格式错误！");
                    }
                }
                else
                {
                    MessageBox.Show("两次密码不相同", "提示");
                }
            }
        }
    }
}
