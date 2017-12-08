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
    public partial class cityall_2 : a_qg_trol.qg_form
    {
        public string cityid = "";
        public string name_all = "";
        public string gj_all = "";
        public string bh_all = "";
        public string sf_all = "";

        public decimal wd_all = 0;
        public decimal jd_all = 0;

        public cityall_2()
        {
            InitializeComponent();
        }
        private void cityall_2_Load(object sender, EventArgs e)
        {
            auto_tag();
            auto();

            name_text.Text = name_all;
            gj_text.Text = gj_all.ToString();
            bh_text.Text = bh_all.ToString();
            sf_text.Text = sf_all.ToString();

            jd_text.Text = wd_all.ToString();
            wd_text.Text = wd_all.ToString();
        }
        #region 城市名称验证


        private void auto_tag()
        {
            name_text.Tag = false;
            gj_text.Tag = false;
            bh_text.Tag = false;
            wd_text.Tag = false;
            jd_text.Tag = false;

            name_text.Focus();
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

            //sfaaa.DataSource =dt_gjaaa.Clone();
            //sqlstring = "select ID,图书类别,拼音 from provinces";
            //DataTable dt_typeaaa = return_select(sqlstring);
            //typeaaa.DataSource = dt_typeaaa;
            //typeaaa.DisplayMember = "图书类别";
            //typeaaa.ValueMember = "ID";
            //typeaaa.SelectedIndex = 0;
        }
        private void name_text_TextChanged(object sender, EventArgs e)
        {
            error_name();
        }

        private void name_text_Validating(object sender, CancelEventArgs e)
        {
            error_name();
        }
        private void error_name()
        {
            bool jytt = true;

            string errorstring = "";
            if (name_text.Text.Trim() == "")
            {
                errorstring = "城市名称不能为空！"; jytt = false; ;
            }
            if (name_text.Text.Trim().Length > 20)
            { errorstring = "城市名称长度不能超过20个字符！"; jytt = false; }

            if (!jytt)
            {
                label_error_name.Text = errorstring;
                label_error_name.Visible = true;
            }
            else
            {
                label_error_name.Visible = false;
                name_text.Tag = true;
            }
        }
        #endregion

        #region 国家验证
        private void gj_text_TextChanged(object sender, EventArgs e)
        {
            error_gj();
        }
        private void gj_text_Validating(object sender, CancelEventArgs e)
        {
            error_gj();
        }
        private void error_gj()
        {
            bool jytt = true;

            string errorstring = "";
            if (gj_text.Text.Trim() == "")
            {
                errorstring = "国家名称不能为空！"; jytt = false; ;
            }
            if (gj_text.Text.Trim().Length > 20)
            { errorstring = "国家名称长度不能超过20个字符！"; jytt = false; }

            if (!jytt)
            {
                label_error_gj.Text = errorstring;
                label_error_gj.Visible = true;
            }
            else
            {
                label_error_gj.Visible = false;
                gj_text.Tag = true;
            }
        }
        #endregion

        #region 国内编号验证
        private void bh_text_TextChanged(object sender, EventArgs e)
        {
            error_bh();

        }
        private void bh_text_Validating(object sender, CancelEventArgs e)
        {
            error_bh();
        }
        private void error_bh()
        {
            bool jytt = true;

            string errorstring = "";
            if (bh_text.Text.Trim() == "")
            {
                errorstring = "国内编号不能为空！"; jytt = false; ;
            }
            if (bh_text.Text.Trim().Length > 20)
            { errorstring = "国内编号长度不能超过20个字符！"; jytt = false; }

            if (!jytt)
            {
                label_error_bh.Text = errorstring;
                label_error_bh.Visible = true;
            }
            else
            {
                label_error_bh.Visible = false;
                bh_text.Tag = true;
            }
        }
        #endregion

        #region 纬度验证
        private void wd_text_ValueChanged(object sender, EventArgs e)
        {
            error_wd();
        }
        private void wd_text_Validating(object sender, CancelEventArgs e)
        {
            error_wd();

        }
        private void error_wd()
        {
            bool jytt = true;

            string errorstring = "";

            if (wd_text.Value < -90)
            { errorstring = "纬度必须大于-90度！"; jytt = false; }

            if (wd_text.Value > 90)
            { errorstring = "纬度必须小于90度！"; jytt = false; }

            //string numStr = wd_text.Value.ToString();
            //int result = numStr.Length - numStr.IndexOf('.') - 1;
            //if (result > 6)
            //{ errorstring = "小数位数不能超过6位！"; jytt = false; }
            if (!jytt)
            {
                label_error_wd.Text = errorstring;
                label_error_wd.Visible = true;
            }
            else
            {
                label_error_wd.Visible = false;
                wd_text.Tag = true;
            }
        }
        #endregion

        #region 经度验证
        private void jd_text_ValueChanged(object sender, EventArgs e)
        {
            error_jd();
        }
        private void jd_text_Validating(object sender, CancelEventArgs e)
        {
            error_jd();
        }
        private void error_jd()
        {
            bool jytt = true;

            string errorstring = "";

            if (jd_text.Value < -180)
            { errorstring = "经度必须大于-180度！"; jytt = false; }

            if (jd_text.Value > 90)
            { errorstring = "经度必须小于180度！"; jytt = false; }

            //string numStr = jd_text.Value.ToString();
            //int result = numStr.Length - numStr.IndexOf('.') - 1;
            //if (result > 6)
            //{ errorstring = "小数位数不能超过6位！"; jytt = false; }
            if (!jytt)
            {
                label_error_jd.Text = errorstring;
                label_error_jd.Visible = true;
            }
            else
            {
                label_error_jd.Visible = false;
                jd_text.Tag = true;
            }
        }
        #endregion


        private void sfaaa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!sfaaa.Text.IsNullOrEmpty())
            {
                sf_text.Text = sfaaa.Text;
            }
        }


        #region 总体验证
        private bool ValidateOK()
        {
            //this.qg_button1.Enabled = ((bool)(this.ISBN_text.Tag) && (bool)(this.name_text.Tag) && (bool)(this.dj_text.Tag));

            return (bool)(this.name_text.Tag)
                && (bool)(this.gj_text.Tag)
                && (bool)(this.bh_text.Tag)
                 && (bool)(this.wd_text.Tag)
                  && (bool)(this.jd_text.Tag);
        }




        #endregion

        private void qg_button1_Click(object sender, EventArgs e)
        {
            if (!ValidateOK())
            {
                name_text_Validating(name_text, null);
                gj_text_Validating(gj_text, null);
                bh_text_Validating(bh_text, null);
                wd_text_Validating(wd_text, null);
                jd_text_Validating(jd_text, null);
                return;
            }

            string nametemp1 = name_text.Text.Trim();
            string gjtemp1 = gj_text.Text.Trim();
            string bhtemp1 = bh_text.Text.Trim();
            decimal wdtemp1 = wd_text.Value;
            decimal jdtemp1 = jd_text.Value;
            string sftemp1 = sf_text.Text.Trim();

            //如果省份为null,则不拷贝省份
            bool sfjytt = true;
            if (sftemp1 == "null") { sfjytt = false; }

            string sqlstring;
            DataTable dt;

            sqlstring = "select ID"
                  + ",国家ID,所在国家=isnull((select 国家 from country where ID=c.国家ID),'')"
                 + " from city c where  ID!=" + cityid + " and 城市名称='" + nametemp1.Trim() + "' and 国内编号='" + bhtemp1.Trim() + "'";
            dt = return_select(sqlstring);
            if (dt.Rows.Count > 0)
            {
                string temp1 = "";
                temp1 = temp1 + "\r 国家名称：" + dt.Rows[0]["所在国家"].ToString();
                temp1 = temp1 + "\r城市名称：" + nametemp1.Trim();
                temp1 = temp1 + "\r国内编号：" + bhtemp1.Trim();
                MessageBox.Show("数据库中已经存在相同城市名称或编号！" + temp1);
                return;
            }

            sqlstring = "select ID"
                  + ",国家ID,所在国家=isnull((select 国家 from country where ID=c.国家ID),'')"
                 + " from city c where ID!=" + cityid + " and 纬度=" + wd_text.Text + " and 经度=" + jd_text.Text;
            dt = return_select(sqlstring);
            if (dt.Rows.Count > 0)
            {
                string temp1 = "";
                temp1 = temp1 + "\r 国家名称：" + dt.Rows[0]["所在国家"].ToString();
                temp1 = temp1 + "\r城市名称：" + nametemp1.Trim();
                temp1 = temp1 + "\r国内编号：" + bhtemp1.Trim();
                temp1 = temp1 + "\r纬度：" + wd_text.Text;
                temp1 = temp1 + "\r经度：" + jd_text.Text;
                MessageBox.Show("数据库中已经存在相同经度纬度的城市！" + temp1);
                return;
            }


            string counid = "0";
            sqlstring = "select ID from country where 国家='" + gjtemp1.Trim() + "'";
            dt = return_select(sqlstring);
            if (dt.Rows.Count <= 0)
            {
                string gjbytemp1 = MyPinYin.GetFirst(gj_text.Text.Trim());
                sqlstring = "insert into country(国家,拼音) values ('" + gjtemp1.Trim() + "','"+gjbytemp1+"')";
                insert_update_delete(sqlstring);
                sqlstring = "select ID from country where 国家='" + gjtemp1.Trim() + "'";
                dt = return_select(sqlstring);
            }
            counid = dt.Rows[0]["ID"].ToString();

            string proid = "0";
            if (sfjytt)
            {
                sqlstring = "select ID from provinces where 国家ID=" + counid + " and 省份='" + sftemp1.Trim() + "'";
                dt = return_select(sqlstring);
                if (dt.Rows.Count <= 0)
                {
                    string sfbytemp1 = MyPinYin.GetFirst(sf_text.Text.Trim());
                    sqlstring = "insert into provinces(国家ID,省份,拼音) values (" + counid + ",'" + sftemp1.Trim() + "','" + sfbytemp1 + "')";
                    insert_update_delete(sqlstring);
                    sqlstring = "select ID from provinces where 国家ID=" + counid + " and 省份='" + sftemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                }
                proid = dt.Rows[0]["ID"].ToString();
            }


            string namebytemp1 = MyPinYin.GetFirst(name_text.Text.Trim());
            sqlstring = "update city set 城市名称='" + name_text.Text.Trim() + "',拼音='" + namebytemp1 + "'"
                  + ",国内编号='" + bh_text.Text.Trim() + "'"
                    + ",国家ID=" + counid
                    + ",纬度=" + wd_text.Text + ",经度=" + jd_text.Text
                      + ",省份ID=" + proid ;
            sqlstring =sqlstring+" where ID=" + cityid;
            insert_update_delete(sqlstring);

            cityall frm1 = (cityall)this.Owner;
            //frm1.auto();
            DataTable owner_dt = frm1.grid_datasource();
            DataRow[] rows = owner_dt.Select("ID=" + cityid);
            rows[0]["城市名称"] = name_text.Text.Trim();
            rows[0]["所在国家"] = gj_text.Text.Trim();
            rows[0]["国家ID"] = counid;
            rows[0]["省份ID"] = proid;
            rows[0]["所在省份"] = sf_text.Text.Trim();
            rows[0]["纬度"] = wd_text.Text.Trim();
            rows[0]["经度"] = jd_text.Text.Trim();

            Close();
        }



//结束
    }
}
