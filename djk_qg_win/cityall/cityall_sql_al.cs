using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using djk_qg_win.a_sqlconn;
using static djk_qg_win.a_GlobalClass.con_sql;
namespace djk_qg_win.cityall
{
    public partial class cityall_sql_al : a_qg_trol.qg_form
    {
        public string gjidall="0";

        private cityall_hz_sum sum1 = new cityall_hz_sum(); // 全局变量

        private cityall_sum_tb sum2 = new cityall_sum_tb(); // 全局变量

        public cityall_sql_al()
        {
            InitializeComponent();
            auto();
            sqltemp();
        }
        private void sqltemp()
        {
            string sqlstring;
            DataTable dt;

            sqlstring = "update sql_temp set 查询ID=''";
            insert_update_delete(sqlstring);

        }
        private void qg_combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!gjaaa.Text.IsNullOrEmpty())
            {
                if (gj_text.Text.Trim() != "") { gj_text.Text = gj_text.Text.Trim() + ","; }
                gj_text.Text = gj_text.Text+gjaaa.Text;

                if (gjidall.Trim() != "") { gjidall = gjidall.Trim() + ","; }
                gjidall = gjidall + gjaaa.SelectedValue.ToString();


                string sqlstring;
                DataTable dt;

                sqlstring = "update sql_temp 查询ID='"+gjidall+"'";
                insert_update_delete(sqlstring);
            }
        }


        public void auto()
        {
            string sqlstring;

            sqlstring = "select ID,国家,拼音 from country";
            DataTable dt_gjaaa = return_select(sqlstring);
            gjaaa.DataSource = dt_gjaaa;
            gjaaa.DisplayMember = "国家";
            gjaaa.ValueMember = "ID";
            if (dt_gjaaa.Rows.Count > 0)
            {
                gjaaa.SelectedIndex = 0;
            }
        }
        private void form_hide()
        {
            foreach (Control trol in panel1.Controls)
            {
                if (trol is a_qg_trol.qg_form)
                {
                    trol.Hide();
                }
            }
        }
        private void qg_button1_Click(object sender, EventArgs e)
        {
            form_hide();

            if (sum1 != null)
            {
                sum1.FormBorderStyle = FormBorderStyle.None; // 无边框
                sum1.TopLevel = false; // 不是最顶层窗体
                panel1.Controls.Add(sum1);  // 添加到 Panel中
                sum1.Show();     // 显示
                //book_cbs.Dock = DockStyle.Fill;
                sum1.Top = 0;
                sum1.Left = 5;
                sum1.Height = panel1.Height - 10;
                sum1.Width = panel1.Width - 10;
            }
        }

        private void qg_button3_Click(object sender, EventArgs e)
        {

        }

        private void cityall_sql_al_Load(object sender, EventArgs e)
        {

        }
    }
}
