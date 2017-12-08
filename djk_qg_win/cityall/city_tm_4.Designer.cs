namespace djk_qg_win.cityall
{
    partial class city_tm_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qg_bt_label1 = new djk_qg_win.a_qg_trol.qg_bt_label();
            this.qg_button1 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button2 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button_quit1 = new djk_qg_win.a_qg_trol.qg_button_quit();
            this.grid_citysall = new djk_qg_win.a_qg_trol.qg_grid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.省份ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.国家ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顺序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.城市名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所在国家 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.国内编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.纬度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所在省份 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_citysall)).BeginInit();
            this.SuspendLayout();
            // 
            // qg_bt_label1
            // 
            this.qg_bt_label1.AutoSize = true;
            this.qg_bt_label1.BackColor = System.Drawing.Color.Transparent;
            this.qg_bt_label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qg_bt_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qg_bt_label1.Location = new System.Drawing.Point(375, 5);
            this.qg_bt_label1.Name = "qg_bt_label1";
            this.qg_bt_label1.Size = new System.Drawing.Size(192, 27);
            this.qg_bt_label1.TabIndex = 0;
            this.qg_bt_label1.Text = "qg_bt_label1";
            // 
            // qg_button1
            // 
            this.qg_button1.Location = new System.Drawing.Point(179, 401);
            this.qg_button1.Name = "qg_button1";
            this.qg_button1.Size = new System.Drawing.Size(107, 23);
            this.qg_button1.TabIndex = 2;
            this.qg_button1.Text = "读取txt文件";
            this.qg_button1.UseVisualStyleBackColor = false;
            this.qg_button1.Click += new System.EventHandler(this.qg_button1_Click);
            // 
            // qg_button2
            // 
            this.qg_button2.Location = new System.Drawing.Point(433, 401);
            this.qg_button2.Name = "qg_button2";
            this.qg_button2.Size = new System.Drawing.Size(110, 23);
            this.qg_button2.TabIndex = 3;
            this.qg_button2.Text = "生成txt文件";
            this.qg_button2.UseVisualStyleBackColor = false;
            this.qg_button2.Click += new System.EventHandler(this.qg_button2_Click);
            // 
            // qg_button_quit1
            // 
            this.qg_button_quit1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.qg_button_quit1.Location = new System.Drawing.Point(689, 401);
            this.qg_button_quit1.Name = "qg_button_quit1";
            this.qg_button_quit1.Size = new System.Drawing.Size(75, 23);
            this.qg_button_quit1.TabIndex = 4;
            this.qg_button_quit1.Text = "退  出";
            this.qg_button_quit1.UseVisualStyleBackColor = true;
            // 
            // grid_citysall
            // 
            this.grid_citysall.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.grid_citysall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_citysall.auto_jytt = true;
            this.grid_citysall.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_citysall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_citysall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_citysall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.选择,
            this.省份ID,
            this.国家ID,
            this.顺序号,
            this.城市名称,
            this.所在国家,
            this.国内编号,
            this.纬度,
            this.经度,
            this.所在省份});
            this.grid_citysall.Location = new System.Drawing.Point(10, 55);
            this.grid_citysall.Name = "grid_citysall";
            this.grid_citysall.RowHeadersVisible = false;
            this.grid_citysall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_citysall.RowTemplate.Height = 30;
            this.grid_citysall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_citysall.Size = new System.Drawing.Size(841, 256);
            this.grid_citysall.TabIndex = 5;
            this.grid_citysall.xz_jytt = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 省份ID
            // 
            this.省份ID.HeaderText = "省份ID";
            this.省份ID.Name = "省份ID";
            this.省份ID.Visible = false;
            // 
            // 国家ID
            // 
            this.国家ID.HeaderText = "国家ID";
            this.国家ID.Name = "国家ID";
            this.国家ID.Visible = false;
            // 
            // 顺序号
            // 
            this.顺序号.HeaderText = "顺序号";
            this.顺序号.Name = "顺序号";
            // 
            // 城市名称
            // 
            this.城市名称.HeaderText = "城市名称";
            this.城市名称.Name = "城市名称";
            // 
            // 所在国家
            // 
            this.所在国家.HeaderText = "所在国家";
            this.所在国家.Name = "所在国家";
            // 
            // 国内编号
            // 
            this.国内编号.HeaderText = "国内编号";
            this.国内编号.Name = "国内编号";
            // 
            // 纬度
            // 
            this.纬度.HeaderText = "纬度";
            this.纬度.Name = "纬度";
            // 
            // 经度
            // 
            this.经度.HeaderText = "经度";
            this.经度.Name = "经度";
            // 
            // 所在省份
            // 
            this.所在省份.HeaderText = "所在省份";
            this.所在省份.Name = "所在省份";
            // 
            // city_tm_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 452);
            this.Controls.Add(this.grid_citysall);
            this.Controls.Add(this.qg_button_quit1);
            this.Controls.Add(this.qg_button2);
            this.Controls.Add(this.qg_button1);
            this.Controls.Add(this.qg_bt_label1);
            this.Name = "city_tm_4";
            this.Text = "qg_bt_label1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_citysall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private a_qg_trol.qg_bt_label qg_bt_label1;
        private a_qg_trol.qg_button qg_button1;
        private a_qg_trol.qg_button qg_button2;
        private a_qg_trol.qg_button_quit qg_button_quit1;
        private a_qg_trol.qg_grid grid_citysall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 省份ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 国家ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顺序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 城市名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在国家;
        private System.Windows.Forms.DataGridViewTextBoxColumn 国内编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 纬度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在省份;
    }
}