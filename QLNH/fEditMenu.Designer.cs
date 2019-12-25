namespace QLNH
{
    partial class fEditMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.tbIDcategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tbFoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFoodPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCategory);
            this.tabControl1.Controls.Add(this.tpFood);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.tbIDcategory);
            this.tpCategory.Controls.Add(this.label1);
            this.tpCategory.Controls.Add(this.tbNameCategory);
            this.tpCategory.Controls.Add(this.label8);
            this.tpCategory.Controls.Add(this.button2);
            this.tpCategory.Controls.Add(this.button3);
            this.tpCategory.Controls.Add(this.button4);
            this.tpCategory.Controls.Add(this.button5);
            this.tpCategory.Controls.Add(this.dgvCategory);
            this.tpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpCategory.Location = new System.Drawing.Point(4, 33);
            this.tpCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCategory.Size = new System.Drawing.Size(853, 439);
            this.tpCategory.TabIndex = 0;
            this.tpCategory.Text = "Thay đổi Danh mục    ";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // tbIDcategory
            // 
            this.tbIDcategory.Location = new System.Drawing.Point(637, 86);
            this.tbIDcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIDcategory.Name = "tbIDcategory";
            this.tbIDcategory.ReadOnly = true;
            this.tbIDcategory.Size = new System.Drawing.Size(196, 26);
            this.tbIDcategory.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(469, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID:";
            // 
            // tbNameCategory
            // 
            this.tbNameCategory.Location = new System.Drawing.Point(637, 127);
            this.tbNameCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameCategory.Name = "tbNameCategory";
            this.tbNameCategory.Size = new System.Drawing.Size(196, 26);
            this.tbNameCategory.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(461, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Tên danh mục:";
            // 
            // button2
            // 
            this.button2.Image = global::QLNH.Resources.find__1_;
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 51;
            this.button2.Text = "Xem";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QLNH.Resources._2Sua;
            this.button3.Location = new System.Drawing.Point(587, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 50);
            this.button3.TabIndex = 50;
            this.button3.Text = "Sửa";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::QLNH.Resources._3Xoa;
            this.button4.Location = new System.Drawing.Point(461, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 50);
            this.button4.TabIndex = 49;
            this.button4.Text = "Xóa";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::QLNH.Properties.Resources._1Them;
            this.button5.Location = new System.Drawing.Point(717, 169);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 50);
            this.button5.TabIndex = 48;
            this.button5.Text = "Thêm";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCategory.Location = new System.Drawing.Point(3, 63);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowHeadersWidth = 49;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(456, 309);
            this.dgvCategory.TabIndex = 47;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.tbFoodID);
            this.tpFood.Controls.Add(this.label3);
            this.tpFood.Controls.Add(this.tbFoodPrice);
            this.tpFood.Controls.Add(this.label6);
            this.tpFood.Controls.Add(this.cbCategory);
            this.tpFood.Controls.Add(this.label5);
            this.tpFood.Controls.Add(this.tbFoodName);
            this.tpFood.Controls.Add(this.label4);
            this.tpFood.Controls.Add(this.btnShow);
            this.tpFood.Controls.Add(this.btnEditFood);
            this.tpFood.Controls.Add(this.btnDeleteFood);
            this.tpFood.Controls.Add(this.btnAddFood);
            this.tpFood.Controls.Add(this.dgvFood);
            this.tpFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpFood.Location = new System.Drawing.Point(4, 33);
            this.tpFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFood.Size = new System.Drawing.Size(853, 439);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thay đổi Món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tbFoodID
            // 
            this.tbFoodID.Location = new System.Drawing.Point(601, 90);
            this.tbFoodID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFoodID.Name = "tbFoodID";
            this.tbFoodID.ReadOnly = true;
            this.tbFoodID.Size = new System.Drawing.Size(235, 26);
            this.tbFoodID.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(473, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID:";
            // 
            // tbFoodPrice
            // 
            this.tbFoodPrice.Location = new System.Drawing.Point(601, 208);
            this.tbFoodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFoodPrice.Name = "tbFoodPrice";
            this.tbFoodPrice.Size = new System.Drawing.Size(235, 26);
            this.tbFoodPrice.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(464, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Đơn giá:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(601, 169);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(235, 28);
            this.cbCategory.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(469, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Loại:";
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(601, 130);
            this.tbFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(235, 26);
            this.tbFoodName.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(468, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tên món:";
            // 
            // btnShow
            // 
            this.btnShow.Image = global::QLNH.Resources.find__1_;
            this.btnShow.Location = new System.Drawing.Point(3, 6);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 50);
            this.btnShow.TabIndex = 36;
            this.btnShow.Text = "Xem";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Image = global::QLNH.Resources._2Sua;
            this.btnEditFood.Location = new System.Drawing.Point(592, 252);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(104, 50);
            this.btnEditFood.TabIndex = 35;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click_1);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Image = global::QLNH.Resources._3Xoa;
            this.btnDeleteFood.Location = new System.Drawing.Point(469, 252);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(103, 50);
            this.btnDeleteFood.TabIndex = 34;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click_1);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Image = global::QLNH.Properties.Resources._1Them;
            this.btnAddFood.Location = new System.Drawing.Point(717, 252);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(113, 50);
            this.btnAddFood.TabIndex = 33;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click_1);
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFood.Location = new System.Drawing.Point(3, 63);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 49;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(456, 309);
            this.dgvFood.TabIndex = 32;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick_1);
            // 
            // fEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fEditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Thực đơn";
            this.tabControl1.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TextBox tbFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFoodPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TextBox tbIDcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}