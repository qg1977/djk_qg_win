using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using djk_qg_win.a_sqlconn;
using static djk_qg_win.a_GlobalClass.con_sql;

namespace djk_qg_win.cityall
{
    public partial class read_text : a_qg_trol.qg_form
    {
        public read_text()
        {
            InitializeComponent();
        }
        private void read_text_Load(object sender, EventArgs e)
        {

        }

        private void boid()
        {
            cityall_ht htall = new cityall_ht();
            DataTable dt = htall.cityall_ht_all("-1");

        }
        private void btn_Read_Click(object sender, EventArgs e)
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
                //使用StreamReader类来读取文件 
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                // 从数据流中读取每一行，直到文件的最后一行，并在rTB_Display.Text中显示出内容 
                string strLine = m_streamReader.ReadLine();
                while (strLine != null)
                {
                    if (strLine.Trim() == "null") { continue; }

                    string[] temp = strLine.Split(',');//用|分组
                    if (temp.Length == 0) { continue; }
                    if (temp.Length != 7)
                    { MessageBox.Show("第" + temp[0].ToString() + "行数据字段数不等于7个，无法备份！"); continue; }

                    string xhtemp1 = temp[0].ToString();//
                    string citytemp1 = temp[1].ToString();
                    string gjtemp1 = temp[2].ToString();
                    string bmtemp1 = temp[3].ToString();
                    string wdtemp1 = temp[4].ToString();
                    string jdtemp1 = temp[5].ToString();
                    string sftemp1 = temp[6].ToString();

                    sqlstring = "select ID from city where 城市名称='" + citytemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                    if (dt.Rows.Count > 0) { continue; }
                    //如果省份为null,则不拷贝省份
                    bool sfjytt = true;
                    if (sftemp1 == "null") { sfjytt = false; }
                    string tempaa = "";
                    tempaa = tempaa + "\r行号：" + xhtemp1
                                  + "\r城市名称：" + citytemp1
                                  + "\r国家：" + gjtemp1
                                  + "\r国内编号：" + bmtemp1
                                  + "\r纬度：" + wdtemp1
                                  + "\r经度：" + jdtemp1
                                  + "\r所在省份：" + sftemp1;
                    WaitFormService.SetText("正在拷贝以下记录：" + tempaa);

                    sqlstring = "select 国家 from country where 国家='" + gjtemp1.Trim() + "'";
                    dt = return_select(sqlstring);
                    if (dt.Rows.Count <= 0)
                    {
                        sqlstring = "insert into country(国家) values ('" + gjtemp1.Trim() + "')";
                        insert_update_delete(sqlstring);
                    }
                    string counid = dt.Rows[0]["ID"].ToString();

                    string proid = "0";
                    if (sfjytt)
                    {
                        sqlstring = "select 省份 from provinces where 省份='" + sftemp1.Trim() + "'";
                        dt = return_select(sqlstring);
                        if (dt.Rows.Count <= 0)
                        {
                            sqlstring = "insert into country(省份) values ('" + sftemp1.Trim() + "')";
                            insert_update_delete(sqlstring);
                        }
                        proid = dt.Rows[0]["ID"].ToString();
                    }

                    sqlstring = "insert into city(行号,城市名称,国家ID,国内编号,纬度,经度";
                    if (sfjytt) { sqlstring = sqlstring + ",省份ID"; }
                    sqlstring = sqlstring + ") values (";
                    sqlstring = sqlstring + xhtemp1 + ",'" + citytemp1.Trim() + "'," + counid + ",'" + bmtemp1.Trim() + "'," + wdtemp1 + "," + jdtemp1;
                    if (sfjytt) { sqlstring = sqlstring + "," + proid; }
                    sqlstring = sqlstring + ")";
                    insert_update_delete(sqlstring);
                    //this.rTB_Display.Text += strLine + "\n";
                    strLine = m_streamReader.ReadLine();
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




    }
}
