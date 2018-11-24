namespace MySchool
{
    partial class frmrq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrq));
            this.lblNo1 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNo1
            // 
            this.lblNo1.AutoSize = true;
            this.lblNo1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo1.Location = new System.Drawing.Point(42, 35);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(47, 19);
            this.lblNo1.TabIndex = 0;
            this.lblNo1.Text = "月：";
            this.lblNo1.Click += new System.EventHandler(this.lblNo1_Click);
            // 
            // lblNo2
            // 
            this.lblNo2.AutoSize = true;
            this.lblNo2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNo2.Location = new System.Drawing.Point(42, 84);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(47, 19);
            this.lblNo2.TabIndex = 1;
            this.lblNo2.Text = "日：";
            this.lblNo2.Click += new System.EventHandler(this.lblNo2_Click);
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo1.Location = new System.Drawing.Point(107, 33);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 20);
            this.cbo1.TabIndex = 2;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(107, 82);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(121, 20);
            this.cbo2.TabIndex = 3;
            this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
            // 
            // jd4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 141);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.lblNo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jd4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日期";
            this.Load += new System.EventHandler(this.jd4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo1;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.ComboBox cbo2;
    }
}