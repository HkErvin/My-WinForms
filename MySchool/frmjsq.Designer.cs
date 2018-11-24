namespace MySchool
{
    partial class frmjsq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjsq));
            this.cboysf = new System.Windows.Forms.ComboBox();
            this.lblNo1 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.lblNo3 = new System.Windows.Forms.Label();
            this.lblNo4 = new System.Windows.Forms.Label();
            this.txtNo3 = new System.Windows.Forms.TextBox();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboysf
            // 
            this.cboysf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboysf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboysf.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboysf.FormattingEnabled = true;
            this.cboysf.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboysf.Location = new System.Drawing.Point(290, 81);
            this.cboysf.Name = "cboysf";
            this.cboysf.Size = new System.Drawing.Size(121, 24);
            this.cboysf.TabIndex = 1;
            this.cboysf.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblNo1
            // 
            this.lblNo1.AutoSize = true;
            this.lblNo1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo1.Location = new System.Drawing.Point(84, 62);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(76, 16);
            this.lblNo1.TabIndex = 3;
            this.lblNo1.Text = "第一个数";
            // 
            // lblNo2
            // 
            this.lblNo2.AutoSize = true;
            this.lblNo2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo2.Location = new System.Drawing.Point(287, 62);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(59, 16);
            this.lblNo2.TabIndex = 3;
            this.lblNo2.Text = "运算符";
            // 
            // lblNo3
            // 
            this.lblNo3.AutoSize = true;
            this.lblNo3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo3.Location = new System.Drawing.Point(503, 61);
            this.lblNo3.Name = "lblNo3";
            this.lblNo3.Size = new System.Drawing.Size(76, 16);
            this.lblNo3.TabIndex = 3;
            this.lblNo3.Text = "第二个数";
            // 
            // lblNo4
            // 
            this.lblNo4.AutoSize = true;
            this.lblNo4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo4.Location = new System.Drawing.Point(225, 167);
            this.lblNo4.Name = "lblNo4";
            this.lblNo4.Size = new System.Drawing.Size(59, 16);
            this.lblNo4.TabIndex = 4;
            this.lblNo4.Text = "结果：";
            this.lblNo4.Click += new System.EventHandler(this.lblNo4_Click);
            // 
            // txtNo3
            // 
            this.txtNo3.Enabled = false;
            this.txtNo3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo3.Location = new System.Drawing.Point(290, 157);
            this.txtNo3.Name = "txtNo3";
            this.txtNo3.Size = new System.Drawing.Size(121, 26);
            this.txtNo3.TabIndex = 3;
            // 
            // txtNo1
            // 
            this.txtNo1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo1.Location = new System.Drawing.Point(87, 79);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(121, 26);
            this.txtNo1.TabIndex = 0;
            // 
            // txtNo2
            // 
            this.txtNo2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo2.Location = new System.Drawing.Point(506, 81);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(121, 26);
            this.txtNo2.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(449, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "计算";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(575, 226);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "退出";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // frmjsq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Controls.Add(this.txtNo3);
            this.Controls.Add(this.lblNo4);
            this.Controls.Add(this.lblNo3);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.lblNo1);
            this.Controls.Add(this.cboysf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmjsq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.jd3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboysf;
        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.Label lblNo3;
        private System.Windows.Forms.Label lblNo4;
        private System.Windows.Forms.TextBox txtNo3;
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}