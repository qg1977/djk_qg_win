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
using System.IO;

namespace djk_qg_win.cityall
{
    public partial class cityall : a_qg_trol.qg_form
    {
        private string tj_sqlstring_all = "";//附加的查询语句，比如需要加条件查询
        public cityall()
        {
            InitializeComponent();
           
        }

        private void cityall_Load(object sender, EventArgs e)
        {
            auto_size();
            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            biod();
        }

        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            biod();
        }

        #region
        private void auto_size()
        {
            panel1.Height = 50;
            grid_citysall.Top =panel1.Top+panel1.Height +10;

            grid_citysall.Height = grid_citysall.Height+ 50;
            //分页控件布局
            grid_citysall.Height = grid_citysall.Height - pagerControl1.Height - 20;
            pagerControl1.Left = grid_citysall.Left + grid_citysall.Width - pagerControl1.Width - 30;
            pagerControl1.Top = grid_citysall.Top + grid_citysall.Height + 10;

            qg_tip_visible1.Top = qg_button4.Top + qg_button4.Height;
            qg_tip_visible1.Left = qg_button4.Left - (qg_tip_visible1.Width - qg_button4.Width) / 2;

            qg_tip_visible2.Top = qg_dy1.Top + qg_dy1.Height;
            qg_tip_visible2.Left = qg_dy1.Left - (qg_tip_visible2.Width - qg_dy1.Width) / 2;
        }
#endregion


        #region 将grid的table传递到增加或修改表单中
        public DataTable grid_datasource()
        {
            return (DataTable)grid_citysall.DataSource;
        }
        #endregion



        private DataTable biod()
        {
            //cityall_ht htall = new cityall_ht();
            //DataTable dt = htall.cityall_ht_all("");
            DataTable dt = null;
            try
            {
                //WaitFormService.Show();
                //WaitFormService.SetText("正在查询图书信息,请稍候……");
                string sqlstring = "";




                int page = pagerControl1.PageIndex;
                int page_size = pagerControl1.PageSize;

                sqlstring = "select * from "
                    + "(";
                sqlstring = sqlstring + "select  ROW_NUMBER() OVER(ORDER BY ID) 序号"
                     + ",0 选择,ID,顺序号,城市名称,国内编号,纬度,经度"
                    + ",国家ID,所在国家=isnull((select 国家 from country where ID=c.国家ID),'')"
                    + ",isnull(省份ID,'0') 省份ID,所在省份=isnull((select 省份 from provinces where ID=c.省份ID),'')"
                    + " from city c where ID is not  null";
                sqlstring = sqlstring + tj_sqlstring_all;//附加查询条件 
                sqlstring = sqlstring + ") temp where 序号>" + (page - 1) * page_size + " and 序号<=" + page * page_size;

                dt = return_select(sqlstring);
                grid_citysall.DataSource = dt;

                //WaitFormService.Close();

                //qg_pager1.DrawControl(dt.Rows.Count);
                sqlstring = "select count(1) un from city where ID is not null";
                sqlstring = sqlstring + tj_sqlstring_all;//附加查询条件 

                DataTable dt_count = return_select(sqlstring);
                int count;
                count = dt_count.Rows[0]["un"].ToString().ToInt();
                pagerControl1.DrawControl(count);


            }
            catch (Exception ex)
            {
                ex.errormess();
            }
            return dt;
        }


        #region 增加记录后高亮显示新增加的记录
        public void grid_add(DataRow row)
        {
            DataTable dt = (DataTable)grid_citysall.DataSource;

            dt.Rows.Add(row);

            //增加记录后，将光标跳转至新增加的行
            grid_citysall.Rows[grid_citysall.Rows.Count - 2].Selected = true;//选中
            grid_citysall.FirstDisplayedScrollingRowIndex = grid_citysall.Rows.Count - 2; //指定某行为第一个显示的行
            //增加记录后，将光标跳转至新增加的行

            //增加记录后，需要将翻页控件 的总记录数加1
            pagerControl1.DrawControl(pagerControl1.RecordCount + 1);
        }

        #endregion

        private void qg_button1_Click(object sender, EventArgs e)
        {
            //异常检测开始 
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "文本文件|*.txt|所有文件|*.*"; ;
                //openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFile.Multiselect = false;
                if (openFile.ShowDialog() == DialogResult.Cancel) return;
                var excelFilePath = openFile.FileName;


                //OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Title = "打开文件";
                //ofd.Filter = "文本文件|*.txt|所有文件|*.*";
                DialogResult dr = MessageBox.Show("是否确定将txt中的数据备份至数据库中，时间较长，请耐心等待！", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }


                FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);//读取文件设定 
                StreamReader m_streamReader = new StreamReader(fs, System.Text.Encoding.GetEncoding("GB2312"));//设定读写的编码 

                string sqlstring;
                DataTable dt;
                WaitFormService.Show();

                DataTable owner_dt = (DataTable)grid_citysall.DataSource;


                //使用StreamReader类来读取文件 
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                // 从数据流中读取每一行，直到文件的最后一行，并在rTB_Display.Text中显示出内容 
                string strLine = m_streamReader.ReadLine();
                while (strLine != null)
                {
                    if (strLine.Trim() == "null") { strLine = m_streamReader.ReadLine(); continue; }

                    string[] temp = strLine.Split(',');//用|分组
                    if (temp.Length == 0) { continue; }
                    if (temp.Length != 7)
                    {
                        //MessageBox.Show("第" + temp[0].ToString() + "行数据字段数不等于7个，无法备份！");
                        WaitFormService.SetText("第" + temp[0].ToString() + "行数据字段数不等于7个，无法备份！");
                        strLine = m_streamReader.ReadLine();
                        continue; }

                    string xhtemp1 = temp[0].ToString();//
                    string nametemp1 = temp[1].ToString();
                    string gjtemp1 = temp[2].ToString();
                    string bhtemp1 = temp[3].ToString();
                    string wdtemp1 = temp[4].ToString();
                    string jdtemp1 = temp[5].ToString();
                    string sftemp1 = temp[6].ToString();

                    sqlstring = "select ID from city where 城市名称='" + nametemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                    if (dt.Rows.Count > 0) { strLine = m_streamReader.ReadLine(); continue; }
                    //如果省份为null,则不拷贝省份
                    bool sfjytt = true;
                    if (sftemp1 == "null") { sfjytt = false; }

                    sqlstring = "select ID from city c where 城市名称='" + nametemp1.Trim() + "' and 国内编号='" + bhtemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                    if (dt.Rows.Count > 0)
                    {
                        strLine = m_streamReader.ReadLine();
                        continue;
                    }

                    string tempaa = "";
                    tempaa = tempaa + "\r顺序号：" + xhtemp1
                                  + "\r城市名称：" + nametemp1
                                  + "\r国家：" + gjtemp1
                                  + "\r国内编号：" + bhtemp1
                                  + "\r纬度：" + wdtemp1
                                  + "\r经度：" + jdtemp1
                                  + "\r所在省份：" + sftemp1;
                    WaitFormService.SetText("正在拷贝以下记录：" + tempaa);




                    string counid = "0";
                    sqlstring = "select ID from country where 国家='" + gjtemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                    if (dt.Rows.Count <= 0)
                    {
                        string gjbytemp1 = MyPinYin.GetFirst(gjtemp1.Trim());
                        sqlstring = "insert into country(国家,拼音) values ('" + gjtemp1.Trim() + "','" + gjbytemp1 + "')";
                        insert_update_delete(sqlstring);
                        sqlstring = "select ID from country where 国家='" + gjtemp1.Trim() + "'";
                        dt = return_select(sqlstring);
                    }
                     counid = dt.Rows[0]["ID"].ToString();

                    string proid = "0";
                    if (sfjytt)
                    {
                        sqlstring = "select ID from provinces where 省份='" + sftemp1.Trim() + "'";
                        dt = return_select(sqlstring);
                        if (dt.Rows.Count <= 0)
                        {
                            string sfbytemp1 = MyPinYin.GetFirst(sftemp1.Trim());
                            sqlstring = "insert into provinces(国家ID,省份,拼音) values (" + counid + ",'" + sftemp1.Trim() + "','" + sfbytemp1 + "')";
                            insert_update_delete(sqlstring);
                            sqlstring = "select ID from provinces where 省份='" + sftemp1.Trim() + "'";
                            dt = return_select(sqlstring);
                        }
                        proid = dt.Rows[0]["ID"].ToString();
                    }

                    sqlstring = "insert into city(顺序号,城市名称,国家ID,国内编号,纬度,经度";
                    if (sfjytt) { sqlstring = sqlstring + ",省份ID"; }
                    sqlstring = sqlstring + ") values (";
                    sqlstring = sqlstring + xhtemp1 + ",'" + nametemp1.Trim() + "'," + counid + ",'" + bhtemp1.Trim() + "'," + wdtemp1 + "," + jdtemp1;
                    if (sfjytt) { sqlstring = sqlstring + "," + proid; }
                    sqlstring = sqlstring + ")";
                    insert_update_delete(sqlstring);
                    //this.rTB_Display.Text += strLine + "\n";


                    
                    DataRow row = owner_dt.NewRow();
                    //row["ID"] = bookidtempid;
                    row["城市名称"] = nametemp1.Trim();
                    row["所在国家"] =gjtemp1.Trim();
                    row["国内编号"] = bhtemp1.Trim();
                    row["纬度"] = wdtemp1.Trim();
                    row["经度"] = jdtemp1.Trim();
                    row["所在省份"] = sftemp1.Trim();

                    row["国家ID"] = counid;
                    row["省份ID"] = proid;

                    owner_dt.Rows.Add(row);
                    //grid_add(row);


                    strLine = m_streamReader.ReadLine();
                    /*MessageBox.sh(strLine)*/;
                }
                //关闭此StreamReader对象 
                m_streamReader.Close();

                WaitFormService.Close();
            }
            catch (Exception ex)
            {
                ex.errormess();
            }
            //异常检测结束 
        }

        private void qg_button2_Click(object sender, EventArgs e)
        {
            cityall_1 b1 = new cityall_1();
            b1.Owner = this;
            b1.ShowDialog();
        }

        private void qg_button3_Click(object sender, EventArgs e)
        {
            int hh_index = grid_citysall.CurrentCell.RowIndex;

            string cityid = grid_citysall.CurrentRow.Cells["ID"].Value.ToString();//
            string name_all = grid_citysall.CurrentRow.Cells["城市名称"].Value.ToString();
            string gjtemp1 = grid_citysall.CurrentRow.Cells["所在国家"].Value.ToString();
            string bhtemp1 = grid_citysall.CurrentRow.Cells["国内编号"].Value.ToString();
            decimal xdtemp1 = grid_citysall.CurrentRow.Cells["纬度"].Value.ToString().ToDecimal();
            decimal jdtemp1 = grid_citysall.CurrentRow.Cells["经度"].Value.ToString().ToDecimal();
            string sftemp1 = grid_citysall.CurrentRow.Cells["所在省份"].Value.ToString();

            cityall_2 b2 = new cityall_2();
            b2.cityid = cityid;
            b2.name_all = name_all;
            b2.gj_all = gjtemp1;
            b2.bh_all = bhtemp1;
            b2.wd_all = xdtemp1;
            b2.jd_all = jdtemp1;
            b2.sf_all = sftemp1;
            b2.Owner = this;
            b2.ShowDialog();
        }

        private void qg_button4_Click(object sender, EventArgs e)
        {
            DataRow[] row = ((DataTable)grid_citysall.DataSource).Select("选择=1");
            if (row.Count() <= 0) { MessageBox.Show("请将准备删除的记录打勾！"); return; }

            string temp1 = "";
            foreach (DataRow r in row)
            { temp1 = temp1 + "\r城市名称：" + r["城市名称"].ToString().Trim() 
                    + "   " + "所在国家：" + r["所在国家"].ToString().Trim() 
                    + "   " + "国内编号：" + r["国内编号"].ToString().Trim(); }

            DialogResult dr = MessageBox.Show("是否确定删除以下" + row.Count().ToString() + "条记录？" + temp1, "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            string sqlstring;
            foreach (DataRow r in row)
            {
                sqlstring = "delete from city where ID=" + r["ID"].ToString();
                insert_update_delete(sqlstring);

                r.Delete();
            }
            ((DataTable)grid_citysall.DataSource).AcceptChanges();

            //删除记录后，需要将翻页控件 的总记录数减去删除的记录数
            pagerControl1.DrawControl(pagerControl1.RecordCount - row.Count());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //使用红色虚线绘制边框  
            Pen pen1 = new Pen(Color.Red, 1);
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen1.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen1, 0, 0, this.panel1.Width - 1, this.panel1.Height - 1);
        }

        private void qg_button_small1_Click(object sender, EventArgs e)
        {
            if (gj_sql_text.Text.IsNullOrEmpty() && city_sql_text.Text.IsNullOrEmpty())
            {
                MessageBox.Show("请至少选择一种查询条件！");
                return;
            }

            DataTable dt = biod();
            grid_citysall.DataSource = dt;

            string gjliketemp1 = "";
            string cityliketemp1 = "";
            if (!gj_sql_text.Text.IsNullOrEmpty())
            { gjliketemp1 = gj_sql_text.Text.Trim(); }

            if (!city_sql_text.Text.IsNullOrEmpty())
            { cityliketemp1 = city_sql_text.Text.Trim(); }


            string sqltemp = "";        
            if (cityliketemp1 != "") { sqltemp = sqltemp + " and 城市名称 like '%" + cityliketemp1 + "%'"; }

            if (gjliketemp1 != "") { sqltemp = sqltemp + " and 国家ID in (select ID from country where 国家 like '%" + gjliketemp1 + "%')"; }

            pagerControl1.PageIndex = 1;
            tj_sqlstring_all = sqltemp;
            biod();
        }

        private void qg_button_small2_Click(object sender, EventArgs e)
        {
            gj_sql_text.Text = "";
            city_sql_text.Text = "";


            tj_sqlstring_all = "";//复位查询条件 

            DataTable dt = biod();
            grid_citysall.DataSource = dt;
        }
    }
}
