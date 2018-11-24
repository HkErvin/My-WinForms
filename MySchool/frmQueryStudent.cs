using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using CCWin;//(所有窗体样式)

namespace MySchool
{
    public partial class frmQueryStudent : Form
    {
        public frmQueryStudent()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void frmQueryStudent_Load(object sender, EventArgs e)
        {
            BindStudent();
        }
        //连接字符串
        string connString = "Data Source=.;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=ag";
        //绑定学生
        public void BindStudent()
        {
            string sql = "SELECT [StudentNo],[StudentName],[Sex],[GradeName] FROM Student S,Grade g WHERE s.GradeId = g.GradeId";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);//执行命令对象
                SqlDataReader reader = comm.ExecuteReader();//读取数据的方法
                while (reader.Read())
                {
                    ListView lvi = new ListView();//列表项
                    lvi.Text = reader[0].ToString();//学号
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();//关闭连接
            }
        }
    }
}
