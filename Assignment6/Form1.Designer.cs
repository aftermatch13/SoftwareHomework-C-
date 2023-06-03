namespace Order
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbvOrders = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dbvItems = new System.Windows.Forms.DataGridView();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbxField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "添加订单";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "修改订单";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "删除订单";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 107);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.dbvOrders);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dbvItems);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Size = new System.Drawing.Size(787, 331);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(390, 331);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbvOrders
            // 
            this.dbvOrders.AllowUserToAddRows = false;
            this.dbvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbvOrders.Location = new System.Drawing.Point(0, 0);
            this.dbvOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dbvOrders.Name = "dbvOrders";
            this.dbvOrders.RowHeadersWidth = 51;
            this.dbvOrders.RowTemplate.Height = 23;
            this.dbvOrders.Size = new System.Drawing.Size(390, 331);
            this.dbvOrders.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(349, 25);
            this.textBox4.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 25);
            this.textBox2.TabIndex = 1;
            // 
            // dbvItems
            // 
            this.dbvItems.AllowUserToAddRows = false;
            this.dbvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitPrice});
            this.dbvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbvItems.Location = new System.Drawing.Point(0, 0);
            this.dbvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dbvItems.Name = "dbvItems";
            this.dbvItems.RowHeadersWidth = 51;
            this.dbvItems.RowTemplate.Height = 23;
            this.dbvItems.Size = new System.Drawing.Size(393, 331);
            this.dbvItems.TabIndex = 4;
            this.dbvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbvItems_CellContentClick);
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 25);
            this.textBox3.TabIndex = 3;
            // 
            // cbxField
            // 
            this.cbxField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
            this.cbxField.Location = new System.Drawing.Point(1, 28);
            this.cbxField.Margin = new System.Windows.Forms.Padding(4);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(160, 23);
            this.cbxField.TabIndex = 14;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxField);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dbvOrders;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dbvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TextBox textBox3;
    }
}

