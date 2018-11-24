namespace MySchool
{
    partial class frmQQ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "10001",
            "20",
            "男"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "10002",
            "21",
            "男"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "10003",
            "19",
            "女"}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "10004",
            "22",
            "女"}, 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "10005",
            "18",
            "男"}, 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "10006",
            "17",
            "男"}, 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "6",
            "10007",
            "23",
            "男"}, 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "10007",
            "24",
            "女"}, 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "8",
            "10007",
            "16",
            "男"}, 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "9",
            "10008",
            "25",
            "男"}, 9);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "10",
            "10009",
            "17",
            "女"}, 10);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "11",
            "10010",
            "18",
            "女"}, 11);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "12",
            "10011",
            "19",
            "女"}, 12);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "13",
            "10012",
            "22",
            "男"}, 13);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQQ));
            this.lvQQ = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQQNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetials = new System.Windows.Forms.ToolStripMenuItem();
            this.Big = new System.Windows.Forms.ImageList(this.components);
            this.Small = new System.Windows.Forms.ImageList(this.components);
            this.cmsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvQQ
            // 
            this.lvQQ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chQQNo,
            this.chAge,
            this.chSex});
            this.lvQQ.ContextMenuStrip = this.cmsRight;
            this.lvQQ.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.lvQQ.LargeImageList = this.Big;
            this.lvQQ.Location = new System.Drawing.Point(12, 12);
            this.lvQQ.Name = "lvQQ";
            this.lvQQ.Size = new System.Drawing.Size(630, 451);
            this.lvQQ.SmallImageList = this.Small;
            this.lvQQ.TabIndex = 0;
            this.lvQQ.UseCompatibleStateImageBehavior = false;
            this.lvQQ.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "昵称";
            this.chName.Width = 100;
            // 
            // chQQNo
            // 
            this.chQQNo.Text = "QQ号";
            this.chQQNo.Width = 100;
            // 
            // chAge
            // 
            this.chAge.Text = "年龄";
            // 
            // chSex
            // 
            this.chSex.Text = "性别";
            // 
            // cmsRight
            // 
            this.cmsRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBig,
            this.tsmiSmall,
            this.tsmiDetials});
            this.cmsRight.Name = "contextMenuStrip1";
            this.cmsRight.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiBig
            // 
            this.tsmiBig.Name = "tsmiBig";
            this.tsmiBig.Size = new System.Drawing.Size(124, 22);
            this.tsmiBig.Text = "大图标";
            this.tsmiBig.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // tsmiSmall
            // 
            this.tsmiSmall.Name = "tsmiSmall";
            this.tsmiSmall.Size = new System.Drawing.Size(124, 22);
            this.tsmiSmall.Text = "小图标";
            this.tsmiSmall.Click += new System.EventHandler(this.tsmiSmall_Click);
            // 
            // tsmiDetials
            // 
            this.tsmiDetials.Name = "tsmiDetials";
            this.tsmiDetials.Size = new System.Drawing.Size(124, 22);
            this.tsmiDetials.Text = "详细信息";
            this.tsmiDetials.Click += new System.EventHandler(this.tsmiDetials_Click);
            // 
            // Big
            // 
            this.Big.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Big.ImageStream")));
            this.Big.TransparentColor = System.Drawing.Color.Transparent;
            this.Big.Images.SetKeyName(0, "1.bmp");
            this.Big.Images.SetKeyName(1, "2.bmp");
            this.Big.Images.SetKeyName(2, "3.bmp");
            this.Big.Images.SetKeyName(3, "4.bmp");
            this.Big.Images.SetKeyName(4, "5.bmp");
            this.Big.Images.SetKeyName(5, "6.bmp");
            this.Big.Images.SetKeyName(6, "7.bmp");
            this.Big.Images.SetKeyName(7, "8.bmp");
            this.Big.Images.SetKeyName(8, "9.bmp");
            this.Big.Images.SetKeyName(9, "10.bmp");
            this.Big.Images.SetKeyName(10, "11.bmp");
            this.Big.Images.SetKeyName(11, "12.bmp");
            this.Big.Images.SetKeyName(12, "13.bmp");
            this.Big.Images.SetKeyName(13, "14.bmp");
            // 
            // Small
            // 
            this.Small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Small.ImageStream")));
            this.Small.TransparentColor = System.Drawing.Color.Transparent;
            this.Small.Images.SetKeyName(0, "1-1.bmp");
            this.Small.Images.SetKeyName(1, "2-1.bmp");
            this.Small.Images.SetKeyName(2, "3-1.bmp");
            this.Small.Images.SetKeyName(3, "4-1.bmp");
            this.Small.Images.SetKeyName(4, "5-1.bmp");
            this.Small.Images.SetKeyName(5, "6-1.bmp");
            this.Small.Images.SetKeyName(6, "7-1.bmp");
            this.Small.Images.SetKeyName(7, "8-1.bmp");
            this.Small.Images.SetKeyName(8, "9-1.bmp");
            this.Small.Images.SetKeyName(9, "10-1.bmp");
            this.Small.Images.SetKeyName(10, "11-1.bmp");
            this.Small.Images.SetKeyName(11, "12-1.bmp");
            this.Small.Images.SetKeyName(12, "13-1.bmp");
            this.Small.Images.SetKeyName(13, "14-1.bmp");
            // 
            // frmQQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(654, 475);
            this.Controls.Add(this.lvQQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmQQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ";
            this.Load += new System.EventHandler(this.frmQQ_Load);
            this.cmsRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQQ;
        private System.Windows.Forms.ImageList Big;
        private System.Windows.Forms.ImageList Small;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chQQNo;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.ContextMenuStrip cmsRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiBig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetials;
    }
}