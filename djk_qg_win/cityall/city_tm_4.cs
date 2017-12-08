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
    public partial class city_tm_4 : a_qg_trol.qg_form
    {
        public city_tm_4()
        {
            InitializeComponent();
        }

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

                string[] lines = File.ReadAllLines(excelFilePath);//读取所有行
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
                    { WaitFormService.SetText("第" + temp[0].ToString() + "行数据字段数不等于7个，无法备份！"); strLine = m_streamReader.ReadLine(); continue; }

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
                    row["所在国家"] = gjtemp1.Trim();
                    row["国内编号"] = bhtemp1.Trim();
                    row["纬度"] = wdtemp1.Trim();
                    row["经度"] = jdtemp1.Trim();
                    row["所在省份"] = sftemp1.Trim();

                    row["国家ID"] = counid;
                    row["省份ID"] = proid;

                    owner_dt.Rows.Add(row);
                    //grid_add(row);


                    strLine = m_streamReader.ReadLine();
                    /*MessageBox.sh(strLine)*/
                    ;
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
            try
            {
                string sqlstring = "";
            }

            catch (Exception ex)
            {
                ex.errormess();
            }
        }
    }
}
