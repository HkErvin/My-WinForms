namespace MySchool
{
    partial class frmcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcs));
            this.lblcs = new System.Windows.Forms.Label();
            this.lblts = new System.Windows.Forms.Label();
            this.txtcs = new System.Windows.Forms.TextBox();
            this.btnNo1 = new System.Windows.Forms.Button();
            this.btnNo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcs
            // 
            this.lblcs.AutoSize = true;
            this.lblcs.BackColor = System.Drawing.Color.Transparent;
            this.lblcs.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcs.ForeColor = System.Drawing.Color.White;
            this.lblcs.Location = new System.Drawing.Point(160, 75);
            this.lblcs.Name = "lblcs";
            this.lblcs.Size = new System.Drawing.Size(152, 27);
            this.lblcs.TabIndex = 0;
            this.lblcs.Text = "猜数小游戏";
            this.lblcs.Click += new System.EventHandler(this.lblcs_Click);
            // 
            // lblts
            // 
            this.lblts.AutoSize = true;
            this.lblts.BackColor = System.Drawing.Color.Transparent;
            this.lblts.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblts.ForeColor = System.Drawing.Color.White;
            this.lblts.Location = new System.Drawing.Point(59, 157);
            this.lblts.Name = "lblts";
            this.lblts.Size = new System.Drawing.Size(208, 21);
            this.lblts.TabIndex = 1;
            this.lblts.Text = "请输入你猜得数字：";
            // 
            // txtcs
            // 
            this.txtcs.Location = new System.Drawing.Point(255, 157);
            this.txtcs.Name = "txtcs";
            this.txtcs.Size = new System.Drawing.Size(123, 21);
            this.txtcs.TabIndex = 2;
            this.txtcs.TabIndexChanged += new System.EventHandler(this.txtcs_TabIndexChanged);
            this.txtcs.TextChanged += new System.EventHandler(this.txtcs_TextChanged);
            // 
            // btnNo1
            // 
            this.btnNo1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNo1.Location = new System.Drawing.Point(141, 243);
            this.btnNo1.Name = "btnNo1";
            this.btnNo1.Size = new System.Drawing.Size(64, 23);
            this.btnNo1.TabIndex = 3;
            this.btnNo1.Text = "新游戏";
            this.btnNo1.UseVisualStyleBackColor = true;
            this.btnNo1.Click += new System.EventHandler(this.btnNo1_Click);
            // 
            // btnNo2
            // 
            this.btnNo2.Enabled = false;
            this.btnNo2.Location = new System.Drawing.Point(255, 243);
            this.btnNo2.Name = "btnNo2";
            this.btnNo2.Size = new System.Drawing.Size(64, 23);
            this.btnNo2.TabIndex = 4;
            this.btnNo2.Text = "猜一猜";
            this.btnNo2.UseVisualStyleBackColor = true;
            this.btnNo2.Click += new System.EventHandler(this.btnNo2_Click);
            // 
            // frmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.btnNo2);
            this.Controls.Add(this.btnNo1);
            this.Controls.Add(this.txtcs);
            this.Controls.Add(this.lblts);
            this.Controls.Add(this.lblcs);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜数小游戏";
            this.Load += new System.EventHandler(this.jd5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcs;
        private System.Windows.Forms.Label lblts;
        private System.Windows.Forms.TextBox txtcs;
        private System.Windows.Forms.Button btnNo1;
        private System.Windows.Forms.Button btnNo2;
    }
}