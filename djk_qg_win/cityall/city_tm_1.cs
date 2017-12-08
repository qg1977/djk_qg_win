using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using djk_qg_win.a_sqlconn;

namespace djk_qg_win.cityall
{
    public partial class city_tm_1 : a_qg_trol.qg_form
    {
        public city_tm_1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将ASCII码转换为字符
        /// </summary>
        /// <param name="asciiCode"></param>
        /// <returns></returns>
        public string AscllToString(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return strCharacter;
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }
        //private string zf_z_hz()
        //{
        //    //将ASCII字符转换为汉字
        //    string textStr = string.Empty;
        //    int k = 0;//字节移动偏移量
        //    byte[] buffer = new buffer[textAscii.length / 2];//存储变量的字节
        //    for (int i = 0; i < textAscii.length / 2; i++)
        //    {
        //        //每两位合并成为一个字节
        //        buffer[i] = byte.Parse(textAscii.SubString(k, 2),, System.Globalization.NumberStyles.HexNumber);
        //        k = k + 2;
        //    }
        //    //将字节转化成汉字
        //}
        private void qg_button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "文本文件|*.txt|所有文件|*.*"; ;
                //openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFile.Multiselect = false;
                if (openFile.ShowDialog() == DialogResult.Cancel) return;
                var excelFilePath = openFile.FileName;

                string[] lines = File.ReadAllLines(excelFilePath);//读取所有行
                string linestemp1 = lines[0];

                string[] lines_fz= linestemp1.Split(' ');//用|分组
                int lines_fz_lenght = lines_fz.Length;

                string[,] lines_end= new string[lines_fz_lenght / 2+1, 2]; ;

                int ii = 0;
                foreach (string str in lines_fz)
                {
                    string strtemp = str;
                    bool zw_jytt = false;
                    if (str.Contains("-"))
                    {
                        zw_jytt = false;
                        strtemp = str.Replace("-", "");
                    }
                    int jj = 1;
                    if (ii%2==0) { jj = 0; }
                    lines_end[ii/2,jj] = strtemp;

                    //MessageBox.Show(AscllToString(str.ToInt()));
                    ii++;
                }
                



                //FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);//读取文件设定 
                //StreamReader m_streamReader = new StreamReader(fs, System.Text.Encoding.GetEncoding("ANSI"));//设定读写的编码 
            }
            catch (Exception ex)
            {
                ex.errormess();
            }
        }

        private void qg_button2_Click(object sender, EventArgs e)
        {
            string str = "中a";
            //这里我们将采用2字节一个汉字的方法来取出汉字的16进制码
            byte[] textbuf = Encoding.Default.GetBytes(str);
           
            string textAscii = string.Empty;//用来存储转换过后的ASCII码
            for (int i = 0; i < textbuf.Length; i++)
            {
                textAscii += textbuf[i].ToString("");
               

            }

            MessageBox.Show( textAscii);
            //将ASCII字符转换为汉字
            string textStr = string.Empty;
            int k = 0;//字节移动偏移量
            byte[] buffer = new byte[textAscii.Length / 2];//存储变量的字节
            for (int i = 0; i < textAscii.Length / 2; i++)
            {
                //每两位合并成为一个字节
                buffer[i] = byte.Parse(textAscii.Substring(k, 2), System.Globalization.NumberStyles.HexNumber);
                k = k + 2;
            }
            //将字节转化成汉字
            textStr = Encoding.Default.GetString(buffer);
            MessageBox.Show(textStr);
        }

        private void qg_button3_Click(object sender, EventArgs e)
        {
            string sData = "字符串";
            Encoding myEncoding = Encoding.GetEncoding("utf-8");
            byte[] myByte = myEncoding.GetBytes(sData);
            MessageBox.Show(myByte.ToString());
            //short n = -3241;//数字
            //byte[] data = BitConverter.GetBytes(n);//转换为字节数组
            //string s = Encoding.GetEncoding("gb2312").GetString(data);//转换为字符串
            //MessageBox.Show(s);
        }
    }
}
