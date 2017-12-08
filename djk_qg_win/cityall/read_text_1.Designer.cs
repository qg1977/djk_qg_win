namespace djk_qg_win.cityall
{
    partial class read_text_1
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
            this.SuspendLayout();
            // 
            // qg_bt_label1
            // 
            this.qg_bt_label1.AutoSize = true;
            this.qg_bt_label1.BackColor = System.Drawing.Color.Transparent;
            this.qg_bt_label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qg_bt_label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.qg_bt_label1.Location = new System.Drawing.Point(116, 9);
            this.qg_bt_label1.Name = "qg_bt_label1";
            this.qg_bt_label1.Size = new System.Drawing.Size(180, 27);
            this.qg_bt_label1.TabIndex = 1;
            this.qg_bt_label1.Text = "增加城市信息";
            // 
            // read_text_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 454);
            this.Controls.Add(this.qg_bt_label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "read_text_1";
            this.Text = "read_text_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private a_qg_trol.qg_bt_label qg_bt_label1;
    }
}