using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using static djk_qg_win.a_GlobalClass.con_sql;
using djk_qg_win.a_sqlconn;

namespace djk_qg_win.cityall
{
    class cityall_ht
    {
        public DataTable cityall_ht_all(string cusid)
        {
            DataTable dt_permoney = new DataTable();
            try
            {
                string sqlstring = "";

                sqlstring = "select ID,顺序号,城市名称,国内编号,纬度,经度"
                    + ",国家ID,所在国家=isnull((select 国家 from country where ID=c.国家ID),'')"
                    + ",isnull(省份ID,'0') 省份ID,所在省份=isnull((select 省份 from provinces where ID=c.省份ID),'')"
                    + " from city c where ID is not  null";
                if (cusid.Trim()!="")
                { sqlstring=sqlstring+" and 国家ID in ("+cusid+")";}     
                         
                dt_permoney = return_select(sqlstring);

                if (dt_permoney.Rows.Count <= 0) { return null; }

                return dt_permoney;
            }
            catch (Exception ex)
            {
                ex.errormess();
            }

            return dt_permoney;
        }


        public DataTable cityht_all_gj(string cbsid)
        {
            DataTable dt_permoney_bm = null;
            try
            {
                DataTable dt_permoney = cityall_ht_all(cbsid);

                DataColumn dc1 = new DataColumn("排序", Type.GetType("System.Int32"));
                dc1.DefaultValue = 2;
                dt_permoney.Columns.Add(dc1);

                //dc1 = new DataColumn("ID", Type.GetType("System.Int64"));
                //dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("上级ID", Type.GetType("System.Int64"));
                dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("编码", Type.GetType("System.String"));
                dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("展开", Type.GetType("System.Int32"));
                dc1.DefaultValue = 0;
                dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("显示", Type.GetType("System.Int32"));
                dc1.DefaultValue = 0;
                dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("数量排序", Type.GetType("System.Int32"));
                dc1.DefaultValue = 0;
                dt_permoney.Columns.Add(dc1);

                dc1 = new DataColumn("城市数量", Type.GetType("System.Int32"));
                dc1.DefaultValue = 0;
                dt_permoney.Columns.Add(dc1);

                //相当于select 员工ID,月份,sum(工种) 工种,sum(基本工资) group by 员工ID,月份
                #region

                //var query = from t in dt_permoney.AsEnumerable()
                //            group t by new { t1 = t.Field<Int64>("国家ID"), t2 = t.Field<string>("所在国家") } into m
                //            select new
                //            {
                //                国家ID = m.Key.t1,
                //                所在国家 = m.Key.t2,
                //                城市数量 = m.Count(n => n.Field<Int64>("ID")),
                //            };
                //DataTable dtNamex1 = Cs_Datatable.ToDataTable(query.ToList());

                DataTable dtNamex1 = dt_permoney.DefaultView.ToTable(true, "国家ID", "所在国家","城市数量");
                //for (int i = 0; i < dtNamex1.Rows.Count; i++)
                //{
                //    //DataRow[] rows = dt_permoney.Select("国家ID='" + dtnamex2.Rows[i][0] + "' and 所在国家='" + dtnamex2.Rows[i][1] + "'");
                //    int sumtemp1=dt_permoney.Compute("Count(*)", "国家ID='" + dtnamex2.Rows[i][0] + "' and 所在国家='" + dtnamex2.Rows[i][1] + "'").ToString().ToInt() ;
                //    dtnamex2.Rows[i]["城市数量"] = sumtemp1;
                //}
                foreach(DataRow row in dtNamex1.Rows)
                {
                    int sumtemp1 = dt_permoney.Compute("Count(ID)","国家ID="+row["国家ID"]).ToString().ToInt();
                    row["城市数量"] = sumtemp1;
                }
                   



                DataView dtName_dv = dtNamex1.DefaultView;
                dtName_dv.Sort = "城市数量 desc";
                DataTable dtName = dtName_dv.ToTable();

                //LogTextHelper.Info(dtName.Rows[0]["城市数量"].ToString());

                dc1 = new DataColumn("数量排序", Type.GetType("System.Int32"));
                dc1.DefaultValue = 0;
                dtName.Columns.Add(dc1);

                for (int i = 0; i < dtName.Rows.Count; i++)
                {
                    dtName.Rows[i]["数量排序"] = i + 1;
                }
                //将出版社的金额进行合计，最后放到总表的第一行，后面要用
                decimal moneyallall = dtName.Compute("sum(城市数量)", "").ToString().ToDecimal();

                DataTable dtResult = dt_permoney.Clone();//用来将所有汇总后的数据表
                //DataTable dtName = dt_permoney.DefaultView.ToTable(true, "出版社ID", "出版社");

                for (int i = 0; i < dtName.Rows.Count; i++)
                {
                    int px_money = dtName.Rows[i]["数量排序"].ToString().ToInt();
                    string bmidtempid = dtName.Rows[i][0].ToString().Trim();

                    DataRow drtemp1 = dt_permoney.NewRow();
                    drtemp1["国家ID"] = bmidtempid;
                    drtemp1["排序"] = 3;
                    drtemp1["ID"] = 0;
                    drtemp1["数量排序"] = px_money;
                    dt_permoney.Rows.Add(drtemp1);

                    DataRow[] rows = dt_permoney.Select("国家ID='" + bmidtempid + "'", "城市数量 desc");



                    //temp用来存储筛选出来的数据
                    DataTable temp = dtResult.Clone();
                    foreach (DataRow row in rows)
                    {
                        //LogTextHelper.Info("\r\n书名：" + row["书名"].ToString()+"   金额："+row["金额"].ToString());

                        temp.Rows.Add(row.ItemArray);

                        //顺便将员工列的“上级ID”和“编码”定下来
                        row["上级ID"] = bmidtempid;
                        row["编码"] = bmidtempid.Trim() + "-" + row["ID"].ToString().Trim();
                        row["数量排序"] = px_money;
                        //顺便将员工列的“上级ID”和“编码”定下来
                    }


                    DataRow dr = dtResult.NewRow();
                    dr["ID"] = dtName.Rows[i][0].ToString();
                    dr["编码"] = dtName.Rows[i][0].ToString();
                    dr["国家ID"] = dtName.Rows[i][0].ToString();
                    dr["所在国家"] = "● " + dtName.Rows[i][1].ToString();
                    //dr["城市数量"] = dtName.Rows[i]["城市数量"].ToString();
                    dr["排序"] = 1;
                    dr["展开"] = 0;
                    dr["显示"] = 1;
                    dr["数量排序"] = px_money;

                    for (int j = 0; j < temp.Columns.Count; j++)
                    {
                        string columnnametemp1 = temp.Columns[j].ColumnName.ToString().Trim();



                        //if (columnnametemp1 != "出版社ID"
                        //    && columnnametemp1 != "出版社"
                        //    && columnnametemp1 != "员工ID"
                        //    && columnnametemp1 != "姓名"
                        //    && columnnametemp1 != "月份"
                        //    && columnnametemp1 != "上级ID"
                        //    && columnnametemp1 != "编码"
                        //    && (temp.Columns[j].DataType.FullName == "System.Decimal")
                        //    )
                        if (columnnametemp1 == "城市数量")
                        {
                            dr[columnnametemp1] = temp.Compute("count(" + columnnametemp1.Trim() + ")", "");
                            dr[columnnametemp1] = dr[columnnametemp1].ToString().ToInt() - 1;
                            //dr[columnnametemp1] = temp.Compute("sum(" + columnnametemp1.Trim() + ")", "");
                            //dr[columnnametemp1] = 100;
                        }
                    }
                    //dr["工种"] = temp.Compute("max(工种)", "");
                    dtResult.Rows.Add(dr);


                }
                #endregion
                //相当于select 员工ID,月份,sum(工种) 工种,sum(基本工资) group by 员工ID,月份

                //员工工资列的“部门名称”设为“”
                for (int i = 0; i < dt_permoney.Rows.Count; i++)
                {
                    dt_permoney.Rows[i]["所在国家"] = "";  //添加数据行
                }
                //员工工资列的“部门名称”设为“”

                //将部门合计的金额列加入到总表中
                for (int i = 0; i < dtResult.Rows.Count; i++)
                {
                    dt_permoney.Rows.Add(dtResult.Rows[i].ItemArray);  //添加数据行
                }
                //将部门合计的金额列加入到总表中

                //LogTextHelper.Info("\r\n执行前列数：" +dt_permoney.Rows.Count.ToString());
                //将总合计金额放到表头
                DataRow dr_all = dt_permoney.NewRow();
                dr_all["所在国家"] = "合计";
                dr_all["城市数量"] = moneyallall;
                dr_all["数量排序"] = 0;
                dr_all["显示"] = 1;
                dr_all["排序"] = 1;
                dr_all["编码"] = "-1";
                dr_all["ID"] = "0";
                dt_permoney.Rows.Add(dr_all);

                dr_all = dt_permoney.NewRow();
                dr_all["数量排序"] = 0;
                dr_all["显示"] = 1;
                dr_all["排序"] = 3;
                dr_all["编码"] = "-1";
                dr_all["ID"] = "0";
                dt_permoney.Rows.Add(dr_all);
                //将总合计金额放到表头
                //LogTextHelper.Info("\r\n执行后：" + dt_permoney.Rows.Count.ToString());

                //排序
                DataView dv = dt_permoney.DefaultView;
                dv.Sort = "数量排序,国家ID,排序";
                //dt_permoney_bm = dv.ToTable().DefaultView.ToTable(true, "ID", "出版社", "册数", "金额", "ISBN号", "书名","上级ID","编码","展开","显示","排序");
                dt_permoney_bm = dv.ToTable();
                //LogTextHelper.Info("\r\n排序后：" + dt_permoney_bm.Rows.Count.ToString());

                DataRow[] rows1 = dt_permoney_bm.Select("排序=2");
                for (int i = 0; i < rows1.Count(); i++)
                {
                    rows1[i]["所在国家"] = "      " + rows1[i]["城市名称"].ToString() ;
                }

                dt_permoney_bm.Columns["所在国家"].SetOrdinal(1);
                dt_permoney_bm.Columns["城市数量"].SetOrdinal(2);

                //排序
            }
            catch (Exception ex)
            {
                ex.errormess();
            }


            return dt_permoney_bm;
        }



    }
}
