namespace Components
{
    partial class fTableManager
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFinalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtotalPrice = new System.Windows.Forms.TextBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnThayDoiSLBan = new System.Windows.Forms.Button();
            this.btnRefeshTable = new System.Windows.Forms.Button();
            this.btnQuanLyThucDom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BackgroundImage = global::QLNH.Resources.soft_hand_drawn_triangle_pattern_background_in_sketch_style_1017_14894;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbFinalPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbtotalPrice);
            this.panel3.Location = new System.Drawing.Point(601, 636);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 387);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thành tiền";
            // 
            // tbFinalPrice
            // 
            this.tbFinalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbFinalPrice.Location = new System.Drawing.Point(331, 146);
            this.tbFinalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFinalPrice.Name = "tbFinalPrice";
            this.tbFinalPrice.ReadOnly = true;
            this.tbFinalPrice.Size = new System.Drawing.Size(165, 26);
            this.tbFinalPrice.TabIndex = 12;
            this.tbFinalPrice.Text = "0";
            this.tbFinalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "__________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(111, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giảm giá:";
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(429, 74);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(67, 22);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDiscount.ValueChanged += new System.EventHandler(this.nmDiscount_ValueChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(209, 198);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(151, 64);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(111, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền:";
            // 
            // tbtotalPrice
            // 
            this.tbtotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbtotalPrice.Location = new System.Drawing.Point(331, 20);
            this.tbtotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtotalPrice.Name = "tbtotalPrice";
            this.tbtotalPrice.ReadOnly = true;
            this.tbtotalPrice.Size = new System.Drawing.Size(165, 26);
            this.tbtotalPrice.TabIndex = 7;
            this.tbtotalPrice.Text = "0";
            this.tbtotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvBill
            // 
            this.lvBill.BackColor = System.Drawing.SystemColors.Control;
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.ForeColor = System.Drawing.Color.Black;
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(613, 116);
            this.lvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(597, 515);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(887, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 67);
            this.label2.TabIndex = 5;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(1217, 116);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(673, 679);
            this.flpTable.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 171);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 624);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(278, 171);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(329, 624);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Image = global::QLNH.Resources.invoice__1_;
            this.btnDoanhThu.Location = new System.Drawing.Point(12, 31);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(197, 56);
            this.btnDoanhThu.TabIndex = 0;
            this.btnDoanhThu.Text = "DOANH THU";
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnThayDoiSLBan
            // 
            this.btnThayDoiSLBan.Image = global::QLNH.Resources.gnome_preferences_system;
            this.btnThayDoiSLBan.Location = new System.Drawing.Point(466, 29);
            this.btnThayDoiSLBan.Margin = new System.Windows.Forms.Padding(20);
            this.btnThayDoiSLBan.Name = "btnThayDoiSLBan";
            this.btnThayDoiSLBan.Size = new System.Drawing.Size(231, 58);
            this.btnThayDoiSLBan.TabIndex = 11;
            this.btnThayDoiSLBan.Text = "THAY ĐỔI SỐ LƯỢNG BÀN";
            this.btnThayDoiSLBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThayDoiSLBan.UseVisualStyleBackColor = true;
            this.btnThayDoiSLBan.Click += new System.EventHandler(this.btnThayDoiSLBan_Click);
            // 
            // btnRefeshTable
            // 
            this.btnRefeshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefeshTable.Image = global::QLNH.Resources.undo__3_;
            this.btnRefeshTable.Location = new System.Drawing.Point(1217, 29);
            this.btnRefeshTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefeshTable.Name = "btnRefeshTable";
            this.btnRefeshTable.Size = new System.Drawing.Size(152, 58);
            this.btnRefeshTable.TabIndex = 13;
            this.btnRefeshTable.Text = "LOAD LẠI BÀN";
            this.btnRefeshTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefeshTable.UseVisualStyleBackColor = true;
            this.btnRefeshTable.Click += new System.EventHandler(this.btnRefeshTable_Click);
            // 
            // btnQuanLyThucDom
            // 
            this.btnQuanLyThucDom.Image = global::QLNH.Resources.gnome_preferences_system;
            this.btnQuanLyThucDom.Location = new System.Drawing.Point(232, 31);
            this.btnQuanLyThucDom.Margin = new System.Windows.Forms.Padding(20, 2, 3, 2);
            this.btnQuanLyThucDom.Name = "btnQuanLyThucDom";
            this.btnQuanLyThucDom.Size = new System.Drawing.Size(211, 56);
            this.btnQuanLyThucDom.TabIndex = 9;
            this.btnQuanLyThucDom.Text = "QUẢN LÝ THỰC ĐƠN";
            this.btnQuanLyThucDom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThucDom.UseVisualStyleBackColor = true;
            this.btnQuanLyThucDom.Click += new System.EventHandler(this.btnQuanLyThucDon_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLNH.Resources.undo__3_;
            this.button1.Location = new System.Drawing.Point(466, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "LOAD LẠI MENU";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rage Italic", 40.06956F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 80);
            this.label6.TabIndex = 15;
            this.label6.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLNH.Resources.download;
            this.pictureBox1.InitialImage = global::QLNH.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(1643, 800);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 223);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QLNH.Resources.download2;
            this.pictureBox2.InitialImage = global::QLNH.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(12, 800);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 223);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefeshTable);
            this.Controls.Add(this.btnThayDoiSLBan);
            this.Controls.Add(this.btnQuanLyThucDom);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnThayDoiSLBan;
        private System.Windows.Forms.Button btnRefeshTable;
        private System.Windows.Forms.Button btnQuanLyThucDom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFinalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}