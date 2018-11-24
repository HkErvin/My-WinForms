namespace MySchool
{
    partial class frmPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPwd));
            this.btnqd = new System.Windows.Forms.Button();
            this.btnfh = new System.Windows.Forms.Button();
            this.lblNo1 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.lblNo3 = new System.Windows.Forms.Label();
            this.txtymm = new System.Windows.Forms.TextBox();
            this.txtxmm = new System.Windows.Forms.TextBox();
            this.txtqrmm = new System.Windows.Forms.TextBox();
            this.lblNo0 = new System.Windows.Forms.Label();
            this.txtzh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnqd
            // 
            this.btnqd.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqd.Location = new System.Drawing.Point(110, 211);
            this.btnqd.Name = "btnqd";
            this.btnqd.Size = new System.Drawing.Size(75, 23);
            this.btnqd.TabIndex = 4;
            this.btnqd.Text = "确定";
            this.btnqd.UseVisualStyleBackColor = true;
            this.btnqd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfh
            // 
            this.btnfh.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnfh.Location = new System.Drawing.Point(241, 211);
            this.btnfh.Name = "btnfh";
            this.btnfh.Size = new System.Drawing.Size(75, 23);
            this.btnfh.TabIndex = 5;
            this.btnfh.Text = "返回";
            this.btnfh.UseVisualStyleBackColor = true;
            this.btnfh.Click += new System.EventHandler(this.btnfh_Click);
            // 
            // lblNo1
            // 
            this.lblNo1.AutoSize = true;
            this.lblNo1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo1.Location = new System.Drawing.Point(107, 82);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(52, 15);
            this.lblNo1.TabIndex = 2;
            this.lblNo1.Text = "原密码";
            // 
            // lblNo2
            // 
            this.lblNo2.AutoSize = true;
            this.lblNo2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo2.Location = new System.Drawing.Point(107, 120);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(52, 15);
            this.lblNo2.TabIndex = 3;
            this.lblNo2.Text = "新密码";
            // 
            // lblNo3
            // 
            this.lblNo3.AutoSize = true;
            this.lblNo3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo3.Location = new System.Drawing.Point(107, 161);
            this.lblNo3.Name = "lblNo3";
            this.lblNo3.Size = new System.Drawing.Size(67, 15);
            this.lblNo3.TabIndex = 4;
            this.lblNo3.Text = "确认密码";
            // 
            // txtymm
            // 
            this.txtymm.Location = new System.Drawing.Point(180, 76);
            this.txtymm.Name = "txtymm";
            this.txtymm.Size = new System.Drawing.Size(136, 21);
            this.txtymm.TabIndex = 1;
            // 
            // txtxmm
            // 
            this.txtxmm.Location = new System.Drawing.Point(180, 114);
            this.txtxmm.Name = "txtxmm";
            this.txtxmm.Size = new System.Drawing.Size(136, 21);
            this.txtxmm.TabIndex = 2;
            // 
            // txtqrmm
            // 
            this.txtqrmm.Location = new System.Drawing.Point(180, 155);
            this.txtqrmm.Name = "txtqrmm";
            this.txtqrmm.Size = new System.Drawing.Size(136, 21);
            this.txtqrmm.TabIndex = 3;
            // 
            // lblNo0
            // 
            this.lblNo0.AutoSize = true;
            this.lblNo0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo0.Location = new System.Drawing.Point(107, 42);
            this.lblNo0.Name = "lblNo0";
            this.lblNo0.Size = new System.Drawing.Size(40, 16);
            this.lblNo0.TabIndex = 8;
            this.lblNo0.Text = "账号";
            // 
            // txtzh
            // 
            this.txtzh.Location = new System.Drawing.Point(180, 37);
            this.txtzh.Name = "txtzh";
            this.txtzh.Size = new System.Drawing.Size(136, 21);
            this.txtzh.TabIndex = 0;
            // 
            // frmPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 268);
            this.Controls.Add(this.txtzh);
            this.Controls.Add(this.lblNo0);
            this.Controls.Add(this.txtqrmm);
            this.Controls.Add(this.txtxmm);
            this.Controls.Add(this.txtymm);
            this.Controls.Add(this.lblNo3);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.lblNo1);
            this.Controls.Add(this.btnfh);
            this.Controls.Add(this.btnqd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqd;
        private System.Windows.Forms.Button btnfh;
        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.Label lblNo3;
        private System.Windows.Forms.TextBox txtymm;
        private System.Windows.Forms.TextBox txtxmm;
        private System.Windows.Forms.TextBox txtqrmm;
        private System.Windows.Forms.Label lblNo0;
        private System.Windows.Forms.TextBox txtzh;
    }
}