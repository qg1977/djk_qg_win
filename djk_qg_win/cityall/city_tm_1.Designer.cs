namespace djk_qg_win.cityall
{
    partial class city_tm_1
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
            this.qg_bt_label1 = new djk_qg_win.a_qg_trol.qg_bt_label();
            this.qg_text1 = new djk_qg_win.a_qg_trol.qg_text();
            this.qg_button1 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button_quit1 = new djk_qg_win.a_qg_trol.qg_button_quit();
            this.qg_button2 = new djk_qg_win.a_qg_trol.qg_button();
            this.qg_button3 = new djk_qg_win.a_qg_trol.qg_button();
            this.SuspendLayout();
            // 
            // qg_bt_label1
            // 
            this.qg_bt_label1.AutoSize = true;
            this.qg_bt_label1.BackColor = System.Drawing.Color.Transparent;
            this.qg_bt_label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qg_bt_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qg_bt_label1.Location = new System.Drawing.Point(306, 0);
            this.qg_bt_label1.Name = "qg_bt_label1";
            this.qg_bt_label1.Size = new System.Drawing.Size(96, 27);
            this.qg_bt_label1.TabIndex = 0;
            this.qg_bt_label1.Text = "第一题";
            // 
            // qg_text1
            // 
            this.qg_text1.Location = new System.Drawing.Point(13, 51);
            this.qg_text1.Multiline = true;
            this.qg_text1.Name = "qg_text1";
            this.qg_text1.Size = new System.Drawing.Size(705, 264);
            this.qg_text1.TabIndex = 1;
            // 
            // qg_button1
            // 
            this.qg_button1.Location = new System.Drawing.Point(74, 345);
            this.qg_button1.Name = "qg_button1";
            this.qg_button1.Size = new System.Drawing.Size(113, 23);
            this.qg_button1.TabIndex = 2;
            this.qg_button1.Text = "读取txt文件";
            this.qg_button1.UseVisualStyleBackColor = false;
            this.qg_button1.Click += new System.EventHandler(this.qg_button1_Click);
            // 
            // qg_button_quit1
            // 
            this.qg_button_quit1.Location = new System.Drawing.Point(560, 355);
            this.qg_button_quit1.Name = "qg_button_quit1";
            this.qg_button_quit1.Size = new System.Drawing.Size(75, 23);
            this.qg_button_quit1.TabIndex = 3;
            this.qg_button_quit1.Text = "qg_button_quit1";
            this.qg_button_quit1.UseVisualStyleBackColor = true;
            // 
            // qg_button2
            // 
            this.qg_button2.Location = new System.Drawing.Point(302, 345);
            this.qg_button2.Name = "qg_button2";
            this.qg_button2.Size = new System.Drawing.Size(75, 23);
            this.qg_button2.TabIndex = 4;
            this.qg_button2.Text = "qg_button2";
            this.qg_button2.UseVisualStyleBackColor = false;
            this.qg_button2.Click += new System.EventHandler(this.qg_button2_Click);
            // 
            // qg_button3
            // 
            this.qg_button3.Location = new System.Drawing.Point(400, 345);
            this.qg_button3.Name = "qg_button3";
            this.qg_button3.Size = new System.Drawing.Size(75, 23);
            this.qg_button3.TabIndex = 5;
            this.qg_button3.Text = "qg_button3";
            this.qg_button3.UseVisualStyleBackColor = false;
            this.qg_button3.Click += new System.EventHandler(this.qg_button3_Click);
            // 
            // city_tm_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.qg_button3);
            this.Controls.Add(this.qg_button2);
            this.Controls.Add(this.qg_button_quit1);
            this.Controls.Add(this.qg_button1);
            this.Controls.Add(this.qg_text1);
            this.Controls.Add(this.qg_bt_label1);
            this.Name = "city_tm_1";
            this.Text = "city_tm_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private a_qg_trol.qg_bt_label qg_bt_label1;
        private a_qg_trol.qg_text qg_text1;
        private a_qg_trol.qg_button qg_button1;
        private a_qg_trol.qg_button_quit qg_button_quit1;
        private a_qg_trol.qg_button qg_button2;
        private a_qg_trol.qg_button qg_button3;
    }
}