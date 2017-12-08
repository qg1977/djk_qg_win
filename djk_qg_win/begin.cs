using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using static djk_qg_win.a_GlobalClass.con_sql;
using djk_qg_win.a_sqlconn;

namespace djk_qg_win
{
    class begin
    {
        public static void auto()
        {
            try {

                //其它的一些全局变量
                a_GlobalClass.begin_public.begin_public_other();

 
            }
            catch (Exception ex)
            {
                ex.errormess();
            }
        }
    }
}
