namespace MySchool
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.lblViper = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(134, 140);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用  户  名:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(135, 228);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 19);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "登陆类型:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPwd.Location = new System.Drawing.Point(136, 182);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(71, 19);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密       码:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(242, 180);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPwd.MaxLength = 15;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '•';
            this.txtPwd.Size = new System.Drawing.Size(172, 22);
            this.txtPwd.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(242, 138);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.MaxLength = 15;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Administrators",
            "Student"});
            this.cboType.Location = new System.Drawing.Point(242, 226);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(172, 22);
            this.cboType.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.Location = new System.Drawing.Point(242, 274);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 27);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.BackColor = System.Drawing.Color.Transparent;
            this.btnEsc.FlatAppearance.BorderSize = 0;
            this.btnEsc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEsc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEsc.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEsc.Location = new System.Drawing.Point(326, 274);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(100, 27);
            this.btnEsc.TabIndex = 4;
            this.btnEsc.Text = "退出";
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // lblViper
            // 
            this.lblViper.AutoSize = true;
            this.lblViper.BackColor = System.Drawing.Color.Transparent;
            this.lblViper.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViper.ForeColor = System.Drawing.Color.White;
            this.lblViper.Location = new System.Drawing.Point(-2, 9);
            this.lblViper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViper.Name = "lblViper";
            this.lblViper.Size = new System.Drawing.Size(209, 71);
            this.lblViper.TabIndex = 5;
            this.lblViper.Text = "Viper";
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.BackColor = System.Drawing.Color.Transparent;
            this.lblTerms.ForeColor = System.Drawing.Color.White;
            this.lblTerms.Location = new System.Drawing.Point(376, 413);
            this.lblTerms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(209, 14);
            this.lblTerms.TabIndex = 6;
            this.lblTerms.Text = "© 2018 Viper, Inc. Terms Privacy";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.lblTerms);
            this.Controls.Add(this.lblViper);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viper [蝰蛇]";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Click += new System.EventHandler(this.frmLogin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Label lblViper;
        private System.Windows.Forms.Label lblTerms;

    }
}

