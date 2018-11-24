namespace MySchool
{
    partial class frmStudentAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentAdm));
            this.gpNo1 = new System.Windows.Forms.GroupBox();
            this.txtPwdok = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblPwdok = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.gpNo2 = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblsr = new System.Windows.Forms.Label();
            this.pSex = new System.Windows.Forms.Panel();
            this.rbtnGril = new System.Windows.Forms.RadioButton();
            this.rbtnBoy = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gpNo1.SuspendLayout();
            this.gpNo2.SuspendLayout();
            this.pSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpNo1
            // 
            this.gpNo1.BackColor = System.Drawing.Color.Transparent;
            this.gpNo1.Controls.Add(this.txtPwdok);
            this.gpNo1.Controls.Add(this.txtPwd);
            this.gpNo1.Controls.Add(this.txtNumber);
            this.gpNo1.Controls.Add(this.lblPwdok);
            this.gpNo1.Controls.Add(this.lblPwd);
            this.gpNo1.Controls.Add(this.lblNumber);
            this.gpNo1.ForeColor = System.Drawing.Color.White;
            this.gpNo1.Location = new System.Drawing.Point(12, 12);
            this.gpNo1.Name = "gpNo1";
            this.gpNo1.Size = new System.Drawing.Size(652, 197);
            this.gpNo1.TabIndex = 0;
            this.gpNo1.TabStop = false;
            this.gpNo1.Text = "用户注册信息";
            // 
            // txtPwdok
            // 
            this.txtPwdok.Location = new System.Drawing.Point(207, 131);
            this.txtPwdok.Name = "txtPwdok";
            this.txtPwdok.PasswordChar = '*';
            this.txtPwdok.Size = new System.Drawing.Size(254, 21);
            this.txtPwdok.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(207, 80);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(254, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(207, 33);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(254, 21);
            this.txtNumber.TabIndex = 0;
            // 
            // lblPwdok
            // 
            this.lblPwdok.AutoSize = true;
            this.lblPwdok.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwdok.Location = new System.Drawing.Point(130, 134);
            this.lblPwdok.Name = "lblPwdok";
            this.lblPwdok.Size = new System.Drawing.Size(71, 15);
            this.lblPwdok.TabIndex = 2;
            this.lblPwdok.Text = "确认密码";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(130, 83);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(39, 15);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(130, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(39, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "学号";
            // 
            // gpNo2
            // 
            this.gpNo2.BackColor = System.Drawing.Color.Transparent;
            this.gpNo2.Controls.Add(this.btnNo);
            this.gpNo2.Controls.Add(this.btnYes);
            this.gpNo2.Controls.Add(this.dtpDate);
            this.gpNo2.Controls.Add(this.cboGrade);
            this.gpNo2.Controls.Add(this.lblsr);
            this.gpNo2.Controls.Add(this.pSex);
            this.gpNo2.Controls.Add(this.txtEmail);
            this.gpNo2.Controls.Add(this.txtAddress);
            this.gpNo2.Controls.Add(this.txtPhone);
            this.gpNo2.Controls.Add(this.txtName);
            this.gpNo2.Controls.Add(this.label6);
            this.gpNo2.Controls.Add(this.label5);
            this.gpNo2.Controls.Add(this.label4);
            this.gpNo2.Controls.Add(this.label3);
            this.gpNo2.Controls.Add(this.lblSex);
            this.gpNo2.Controls.Add(this.lblName);
            this.gpNo2.ForeColor = System.Drawing.Color.White;
            this.gpNo2.Location = new System.Drawing.Point(12, 227);
            this.gpNo2.Name = "gpNo2";
            this.gpNo2.Size = new System.Drawing.Size(652, 253);
            this.gpNo2.TabIndex = 1;
            this.gpNo2.TabStop = false;
            this.gpNo2.Text = "用户基本信息";
            // 
            // btnNo
            // 
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNo.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnNo.Location = new System.Drawing.Point(483, 193);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "取消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYes.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnYes.Location = new System.Drawing.Point(366, 193);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "确认";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(99, 85);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 21);
            this.dtpDate.TabIndex = 5;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "请选择"});
            this.cboGrade.Location = new System.Drawing.Point(99, 134);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(191, 20);
            this.cboGrade.TabIndex = 7;
            // 
            // lblsr
            // 
            this.lblsr.AutoSize = true;
            this.lblsr.Location = new System.Drawing.Point(63, 89);
            this.lblsr.Name = "lblsr";
            this.lblsr.Size = new System.Drawing.Size(29, 12);
            this.lblsr.TabIndex = 13;
            this.lblsr.Text = "生日";
            // 
            // pSex
            // 
            this.pSex.Controls.Add(this.rbtnGril);
            this.pSex.Controls.Add(this.rbtnBoy);
            this.pSex.Location = new System.Drawing.Point(98, 176);
            this.pSex.Name = "pSex";
            this.pSex.Size = new System.Drawing.Size(206, 38);
            this.pSex.TabIndex = 9;
            // 
            // rbtnGril
            // 
            this.rbtnGril.AutoSize = true;
            this.rbtnGril.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnGril.Location = new System.Drawing.Point(105, 12);
            this.rbtnGril.Name = "rbtnGril";
            this.rbtnGril.Size = new System.Drawing.Size(36, 16);
            this.rbtnGril.TabIndex = 1;
            this.rbtnGril.Text = "女";
            this.rbtnGril.UseVisualStyleBackColor = true;
            // 
            // rbtnBoy
            // 
            this.rbtnBoy.AutoSize = true;
            this.rbtnBoy.Checked = true;
            this.rbtnBoy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnBoy.Location = new System.Drawing.Point(4, 12);
            this.rbtnBoy.Name = "rbtnBoy";
            this.rbtnBoy.Size = new System.Drawing.Size(36, 16);
            this.rbtnBoy.TabIndex = 0;
            this.rbtnBoy.TabStop = true;
            this.rbtnBoy.Text = "男";
            this.rbtnBoy.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(366, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(366, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(366, 29);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 21);
            this.txtPhone.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 21);
            this.txtName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(320, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(320, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(320, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(62, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年级";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(62, 193);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(62, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // frmStudentAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(676, 492);
            this.Controls.Add(this.gpNo2);
            this.Controls.Add(this.gpNo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStudentAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增学生";
            this.Load += new System.EventHandler(this.frmStudentAdm_Load);
            this.gpNo1.ResumeLayout(false);
            this.gpNo1.PerformLayout();
            this.gpNo2.ResumeLayout(false);
            this.gpNo2.PerformLayout();
            this.pSex.ResumeLayout(false);
            this.pSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpNo1;
        private System.Windows.Forms.GroupBox gpNo2;
        private System.Windows.Forms.TextBox txtPwdok;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblPwdok;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pSex;
        private System.Windows.Forms.RadioButton rbtnGril;
        private System.Windows.Forms.RadioButton rbtnBoy;
        private System.Windows.Forms.Label lblsr;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}