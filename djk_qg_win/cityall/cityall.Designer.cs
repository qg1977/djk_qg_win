namespace djk_qg_win.cityall
{
    partial class cityall
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
            this.qg_tip_visible1 = new djk_qg_win.a_qg_trol.qg_tip_visible();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qg_button_small2 = new djk_qg_win.a_qg_trol.qg_button_small();
            this.qg_button_small1 = new djk_qg_win.a_qg_trol.qg_button_small();
            this.city_sql_text = new djk_qg_win.a_qg_trol.qg_text();
            this.gj_sql_text = new djk_qg_win.a_qg_trol.qg_text();
            this.qg_label3 = new djk_qg_win.a_qg_trol.qg_label();
            this.qg_label4 = new djk_qg_win.a_qg_trol.qg_label();
            this.pagerControl1 = new djk_qg_win.a_qg_trol.PagerControl();
            this.qg_button_quit1 = new djk_qg_win.a_qg_trol.qg_button_quit();
            this.qg_dy1 = new djk_qg_win.a_qg_trol.qg_dy();
            this.qg_button4 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button3 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button2 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button1 = new djk_qg_win.a_qg_trol.qg_button();
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
            this.qg_bt_label1 = new djk_qg_win.a_qg_trol.qg_bt_label();
            this.qg_tip_visible2 = new djk_qg_win.a_qg_trol.qg_tip_visible();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_citysall)).BeginInit();
            this.SuspendLayout();
            // 
            // qg_tip_visible1
            // 
            this.qg_tip_visible1.AutoSize = true;
            this.qg_tip_visible1.BackColor = System.Drawing.Color.Transparent;
            this.qg_tip_visible1.LabelText = "可以将需要删除的记录一起打勾删除";
            this.qg_tip_visible1.Location = new System.Drawing.Point(292, 441);
            this.qg_tip_visible1.Name = "qg_tip_visible1";
            this.qg_tip_visible1.Size = new System.Drawing.Size(226, 29);
            this.qg_tip_visible1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.qg_button_small2);
            this.panel1.Controls.Add(this.qg_button_small1);
            this.panel1.Controls.Add(this.city_sql_text);
            this.panel1.Controls.Add(this.gj_sql_text);
            this.panel1.Controls.Add(this.qg_label3);
            this.panel1.Controls.Add(this.qg_label4);
            this.panel1.Location = new System.Drawing.Point(22, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 52);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // qg_button_small2
            // 
            this.qg_button_small2.Location = new System.Drawing.Point(655, 13);
            this.qg_button_small2.Name = "qg_button_small2";
            this.qg_button_small2.Size = new System.Drawing.Size(55, 20);
            this.qg_button_small2.TabIndex = 9;
            this.qg_button_small2.Text = "复位";
            this.qg_button_small2.UseVisualStyleBackColor = true;
            this.qg_button_small2.Click += new System.EventHandler(this.qg_button_small2_Click);
            // 
            // qg_button_small1
            // 
            this.qg_button_small1.Location = new System.Drawing.Point(558, 13);
            this.qg_button_small1.Name = "qg_button_small1";
            this.qg_button_small1.Size = new System.Drawing.Size(55, 20);
            this.qg_button_small1.TabIndex = 8;
            this.qg_button_small1.Text = "查询";
            this.qg_button_small1.UseVisualStyleBackColor = true;
            this.qg_button_small1.Click += new System.EventHandler(this.qg_button_small1_Click);
            // 
            // city_sql_text
            // 
            this.city_sql_text.Location = new System.Drawing.Point(377, 17);
            this.city_sql_text.Name = "city_sql_text";
            this.city_sql_text.Size = new System.Drawing.Size(140, 21);
            this.city_sql_text.TabIndex = 7;
            // 
            // gj_sql_text
            // 
            this.gj_sql_text.Location = new System.Drawing.Point(115, 17);
            this.gj_sql_text.Name = "gj_sql_text";
            this.gj_sql_text.Size = new System.Drawing.Size(140, 21);
            this.gj_sql_text.TabIndex = 6;
            // 
            // qg_label3
            // 
            this.qg_label3.AutoSize = true;
            this.qg_label3.BackColor = System.Drawing.Color.Transparent;
            this.qg_label3.Location = new System.Drawing.Point(282, 17);
            this.qg_label3.Name = "qg_label3";
            this.qg_label3.Size = new System.Drawing.Size(101, 12);
            this.qg_label3.TabIndex = 5;
            this.qg_label3.Text = "城市(模糊查询)：";
            // 
            // qg_label4
            // 
            this.qg_label4.AutoSize = true;
            this.qg_label4.BackColor = System.Drawing.Color.Transparent;
            this.qg_label4.Location = new System.Drawing.Point(20, 20);
            this.qg_label4.Name = "qg_label4";
            this.qg_label4.Size = new System.Drawing.Size(101, 12);
            this.qg_label4.TabIndex = 4;
            this.qg_label4.Text = "国家(模糊查询)：";
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "跳转";
            this.pagerControl1.Location = new System.Drawing.Point(101, 371);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 15;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(700, 37);
            this.pagerControl1.TabIndex = 8;
            // 
            // qg_button_quit1
            // 
            this.qg_button_quit1.Location = new System.Drawing.Point(698, 412);
            this.qg_button_quit1.Name = "qg_button_quit1";
            this.qg_button_quit1.Size = new System.Drawing.Size(75, 23);
            this.qg_button_quit1.TabIndex = 7;
            this.qg_button_quit1.Text = "qg_button_quit1";
            this.qg_button_quit1.UseVisualStyleBackColor = true;
            // 
            // qg_dy1
            // 
            this.qg_dy1.dy_month = null;
            this.qg_dy1.dy_title = null;
            this.qg_dy1.Location = new System.Drawing.Point(539, 412);
            this.qg_dy1.Name = "qg_dy1";
            this.qg_dy1.Size = new System.Drawing.Size(75, 23);
            this.qg_dy1.TabIndex = 6;
            this.qg_dy1.Text = "qg_dy1";
            this.qg_dy1.UseVisualStyleBackColor = true;
            // 
            // qg_button4
            // 
            this.qg_button4.Location = new System.Drawing.Point(411, 412);
            this.qg_button4.Name = "qg_button4";
            this.qg_button4.Size = new System.Drawing.Size(75, 23);
            this.qg_button4.TabIndex = 5;
            this.qg_button4.Text = "删 除";
            this.qg_button4.UseVisualStyleBackColor = false;
            this.qg_button4.Click += new System.EventHandler(this.qg_button4_Click);
            // 
            // qg_button3
            // 
            this.qg_button3.Location = new System.Drawing.Point(306, 423);
            this.qg_button3.Name = "qg_button3";
            this.qg_button3.Size = new System.Drawing.Size(75, 23);
            this.qg_button3.TabIndex = 4;
            this.qg_button3.Text = "修 改";
            this.qg_button3.UseVisualStyleBackColor = false;
            this.qg_button3.Click += new System.EventHandler(this.qg_button3_Click);
            // 
            // qg_button2
            // 
            this.qg_button2.Location = new System.Drawing.Point(167, 412);
            this.qg_button2.Name = "qg_button2";
            this.qg_button2.Size = new System.Drawing.Size(75, 23);
            this.qg_button2.TabIndex = 3;
            this.qg_button2.Text = "增 加";
            this.qg_button2.UseVisualStyleBackColor = false;
            this.qg_button2.Click += new System.EventHandler(this.qg_button2_Click);
            // 
            // qg_button1
            // 
            this.qg_button1.Location = new System.Drawing.Point(68, 412);
            this.qg_button1.Name = "qg_button1";
            this.qg_button1.Size = new System.Drawing.Size(75, 23);
            this.qg_button1.TabIndex = 2;
            this.qg_button1.Text = "批量增加";
            this.qg_button1.UseVisualStyleBackColor = false;
            this.qg_button1.Click += new System.EventHandler(this.qg_button1_Click);
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
            this.grid_citysall.Location = new System.Drawing.Point(4, 141);
            this.grid_citysall.Name = "grid_citysall";
            this.grid_citysall.RowHeadersVisible = false;
            this.grid_citysall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_citysall.RowTemplate.Height = 30;
            this.grid_citysall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_citysall.Size = new System.Drawing.Size(831, 200);
            this.grid_citysall.TabIndex = 1;
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
            // qg_bt_label1
            // 
            this.qg_bt_label1.AutoSize = true;
            this.qg_bt_label1.BackColor = System.Drawing.Color.Transparent;
            this.qg_bt_label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qg_bt_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qg_bt_label1.Location = new System.Drawing.Point(329, 13);
            this.qg_bt_label1.Name = "qg_bt_label1";
            this.qg_bt_label1.Size = new System.Drawing.Size(180, 27);
            this.qg_bt_label1.TabIndex = 0;
            this.qg_bt_label1.Text = "城市信息总表";
            // 
            // qg_tip_visible2
            // 
            this.qg_tip_visible2.AutoSize = true;
            this.qg_tip_visible2.BackColor = System.Drawing.Color.Transparent;
            this.qg_tip_visible2.LabelText = "可将表格中数据导出至excel表";
            this.qg_tip_visible2.Location = new System.Drawing.Point(537, 441);
            this.qg_tip_visible2.Name = "qg_tip_visible2";
            this.qg_tip_visible2.Size = new System.Drawing.Size(196, 29);
            this.qg_tip_visible2.TabIndex = 11;
            // 
            // cityall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 476);
            this.Controls.Add(this.qg_tip_visible2);
            this.Controls.Add(this.qg_tip_visible1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pagerControl1);
            this.Controls.Add(this.qg_button_quit1);
            this.Controls.Add(this.qg_dy1);
            this.Controls.Add(this.qg_button4);
            this.Controls.Add(this.qg_button3);
            this.Controls.Add(this.qg_button2);
            this.Controls.Add(this.qg_button1);
            this.Controls.Add(this.grid_citysall);
            this.Controls.Add(this.qg_bt_label1);
            this.Name = "cityall";
            this.Text = "cityall";
            this.Load += new System.EventHandler(this.cityall_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_citysall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private a_qg_trol.qg_bt_label qg_bt_label1;
        private a_qg_trol.qg_grid grid_citysall;
        private a_qg_trol.qg_button qg_button1;
        private a_qg_trol.qg_button qg_button2;
        private a_qg_trol.qg_button qg_button3;
        private a_qg_trol.qg_button qg_button4;
        private a_qg_trol.qg_dy qg_dy1;
        private a_qg_trol.qg_button_quit qg_button_quit1;
        private a_qg_trol.PagerControl pagerControl1;
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
        private System.Windows.Forms.Panel panel1;
        private a_qg_trol.qg_button_small qg_button_small2;
        private a_qg_trol.qg_button_small qg_button_small1;
        private a_qg_trol.qg_text city_sql_text;
        private a_qg_trol.qg_text gj_sql_text;
        private a_qg_trol.qg_label qg_label3;
        private a_qg_trol.qg_label qg_label4;
        private a_qg_trol.qg_tip_visible qg_tip_visible1;
        private a_qg_trol.qg_tip_visible qg_tip_visible2;
    }
}