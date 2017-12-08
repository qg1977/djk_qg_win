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
    public partial class cityall_hz_sum : a_qg_trol.qg_form
    {
        public string gjidall = "";
        public cityall_hz_sum()
        {
            InitializeComponent();

           


        }
        private void cityall_hz_sum_Load(object sender, EventArgs e)
        {
            auto();
        }
        private void gjaaa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!gjaaa.Text.IsNullOrEmpty())
            {
                if (gj_text.Text.Trim() != "") { gj_text.Text = gj_text.Text.Trim() + ","; }
                gj_text.Text = gj_text.Text + gjaaa.Text;

                if (gjidall.Trim() != "") { gjidall = gjidall.Trim() + ","; }
                gjidall = gjidall + gjaaa.SelectedValue.ToString();


            }
        }
        public void auto()
        {
            panel1.Top = 50;
            qg_grid_tree1.Top = panel1.Top + panel1.Height + 10;
            qg_grid_tree1.Height = qg_grid_tree1.Height + 50;

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
        private void boid()
        {
            try
            {
                string sqlstring;
                DataTable dttemp;



                cityall_ht hz = new cityall_ht();
                DataTable dt = hz.cityht_all_gj(gjidall);

                qg_grid_tree1.DataSource = dt;
                qg_grid_tree1.AutoGenerateColumns = true;

                foreach (DataGridViewColumn col in qg_grid_tree1.Columns)
                {
                    if (col.Name == "所在国家"
                        || col.Name == "城市数量") { }
                    else
                    { col.Visible = false; }
                }
            }
            catch (Exception ex)
            {
                ex.errormess();
            }
        }

        private void qg_button_small1_Click(object sender, EventArgs e)
        {
            boid();
        }


    }
}
