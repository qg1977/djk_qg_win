namespace djk_qg_win.cityall
{
    partial class read_text
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qg_button1 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_grid1 = new djk_qg_win.a_qg_trol.qg_grid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.国家ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.省份ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.城市名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所在国家 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.国内编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.纬度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所在省份 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qg_bt_label1 = new djk_qg_win.a_qg_trol.qg_bt_label();
            this.qg_button2 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button_quit1 = new djk_qg_win.a_qg_trol.qg_button_quit();
            ((System.ComponentModel.ISupportInitialize)(this.qg_grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // qg_button1
            // 
            this.qg_button1.Location = new System.Drawing.Point(-204, 332);
            this.qg_button1.Name = "qg_button1";
            this.qg_button1.Size = new System.Drawing.Size(76, 23);
            this.qg_button1.TabIndex = 0;
            this.qg_button1.Text = "批量增加";
            this.qg_button1.UseVisualStyleBackColor = false;
            this.qg_button1.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // qg_grid1
            // 
            this.qg_grid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            this.qg_grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.qg_grid1.auto_jytt = true;
            this.qg_grid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qg_grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.qg_grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qg_grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.国家ID,
            this.省份ID,
            this.行号,
            this.城市名称,
            this.所在国家,
            this.国内编号,
            this.纬度,
            this.经度,
            this.所在省份});
            this.qg_grid1.Location = new System.Drawing.Point(10, 55);
            this.qg_grid1.Name = "qg_grid1";
            this.qg_grid1.RowHeadersVisible = false;
            this.qg_grid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.qg_grid1.RowTemplate.Height = 30;
            this.qg_grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.qg_grid1.Size = new System.Drawing.Size(926, 187);
            this.qg_grid1.TabIndex = 1;
            this.qg_grid1.xz_jytt = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // 国家ID
            // 
            this.国家ID.HeaderText = "国家ID";
            this.国家ID.Name = "国家ID";
            this.国家ID.Visible = false;
            // 
            // 省份ID
            // 
            this.省份ID.HeaderText = "省份ID";
            this.省份ID.Name = "省份ID";
            this.省份ID.Visible = false;
            // 
            // 行号
            // 
            this.行号.HeaderText = "行号";
            this.行号.Name = "行号";
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
            this.qg_bt_label1.Location = new System.Drawing.Point(355, 5);
            this.qg_bt_label1.Name = "qg_bt_label1";
            this.qg_bt_label1.Size = new System.Drawing.Size(236, 27);
            this.qg_bt_label1.TabIndex = 2;
            this.qg_bt_label1.Text = "拷贝城市信息文件";
            // 
            // qg_button2
            // 
            this.qg_button2.Location = new System.Drawing.Point(258, 338);
            this.qg_button2.Name = "qg_button2";
            this.qg_button2.Size = new System.Drawing.Size(75, 23);
            this.qg_button2.TabIndex = 3;
            this.qg_button2.Text = "qg_button2";
            this.qg_button2.UseVisualStyleBackColor = false;
            // 
            // qg_button_quit1
            // 
            this.qg_button_quit1.Location = new System.Drawing.Point(734, 326);
            this.qg_button_quit1.Name = "qg_button_quit1";
            this.qg_button_quit1.Size = new System.Drawing.Size(75, 23);
            this.qg_button_quit1.TabIndex = 4;
            this.qg_button_quit1.Text = "qg_button_quit1";
            this.qg_button_quit1.UseVisualStyleBackColor = true;
            // 
            // read_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 383);
            this.Controls.Add(this.qg_button_quit1);
            this.Controls.Add(this.qg_button2);
            this.Controls.Add(this.qg_bt_label1);
            this.Controls.Add(this.qg_grid1);
            this.Controls.Add(this.qg_button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "read_text";
            this.Text = "拷贝城市信息文件";
            this.Load += new System.EventHandler(this.read_text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qg_grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private a_qg_trol.qg_button qg_button1;
        private a_qg_trol.qg_grid qg_grid1;
        private a_qg_trol.qg_bt_label qg_bt_label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 国家ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 省份ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 城市名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在国家;
        private System.Windows.Forms.DataGridViewTextBoxColumn 国内编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 纬度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 经度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在省份;
        private a_qg_trol.qg_button qg_button2;
        private a_qg_trol.qg_button_quit qg_button_quit1;
    }
}