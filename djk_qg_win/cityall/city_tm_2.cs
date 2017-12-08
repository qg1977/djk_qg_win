using System;
using System.Collections.Generic;
using static djk_qg_win.a_GlobalClass.con_sql;
using djk_qg_win.a_sqlconn;
namespace djk_qg_win.cityall
{
    public partial class city_tm_2 : a_qg_trol.qg_form
    {
        private string szallall = "";

        /// <summary>  
        /// 数组存储树的结构(还有一种是Node)  
        /// </summary>  
        private int[] data;//从1开始存储数据  
        /// <summary>  
        /// 树的长度  
        /// </summary>  
        private int len;

        /// <summary>  
        /// 删除节点时用的一个临时的数据结构  
        /// </summary>  
        private List<int> tmpList;
        public void Tree()
        {
            //先初始化一个1w大小的数组  
            this.data = new int[100];
            tmpList = new List<int>();
            len = 0;
        }
        /// <summary>  
        /// 把节点插入树  
        /// </summary>  
        public void Insert(int key)
        {
            if (len == 0)
            {
                data[1] = key;
                len++;
            }
            else
            {
                int index = 1;
                while (index < data.Length)
                {
                    if (key < data[index])
                    {
                        //拓展数组  
                        if (LeftChild(index) >= data.Length)
                            Expand();
                        //判断这个节点是否为空  
                        if (data[LeftChild(index)] == 0)
                        {
                            data[LeftChild(index)] = key;
                            len++;
                            break;
                        }
                        else
                        {
                            index = LeftChild(index);
                        }
                    }
                    else
                    {
                        //拓展数组  
                        if (RightChild(index) >= data.Length)
                            Expand();
                        //判断这个节点是否为空  
                        if (data[RightChild(index)] == 0)
                        {
                            data[RightChild(index)] = key;
                            len++;
                            break;
                        }
                        else
                        {
                            index = RightChild(index);
                        }
                    }
                }
            }

        }
        /// <summary>  
        /// 删除树的节点  
        /// </summary>  
        public int Delete(int key)
        {
            int value = -1;
            int index = Search(key);
            if (index != -1)
            {
                value = data[index];
                Remove(index);
            }
            return value;

        }
        /// <summary>  
        /// 移除一个节点，并重新构造树  
        /// </summary>  
        /// <param name="index"></param>  
        private void Remove(int index)
        {
            //设置要删除的值为0  
            data[index] = 0;
            //删除指定下标处的元素,并得到删除后的树（调整位置）  
            List<int> it = PreInorderList();//得到前序遍历的迭代器  
            for (int i = 1; i < data.Length; i++)//将树清空  
                data[i] = 0;
            //把树给清空，长度也变为0  
            len = 0;
            foreach (int item in it)
            {
                Insert(item);
            }
        }
        /// <summary>  
        /// 获取先序遍历的序列  
        /// </summary>  
        /// <returns></returns>  
        private List<int> PreInorderList()
        {
            //生成前序序列  
            PreOrder(1);
            List<int> tmp = tmpList;
            //重新把这个初始为空  
            tmpList = new List<int>();
            return tmp;
        }
        /// <summary>  
        /// 获取左孩子  
        /// </summary>  
        /// <param name="i"></param>  
        /// <returns></returns>  
        private int LeftChild(int i)
        {
            return i * 2;
        }
        /// <summary>  
        /// 获取右孩子  
        /// </summary>  
        /// <param name="i"></param>  
        /// <returns></returns>  
        private int RightChild(int i)
        {
            return i * 2 + 1;
        }

        /// <summary>  
        /// 当容量不够的时候拓展数组的大小  
        /// </summary>  
        private void Expand()
        {
            //一次扩大两倍  
            int[] larger = new int[data.Length * 2];

            for (int i = 1; i < data.Length; i++)
            {
                larger[i] = data[i];
            }
            data = larger;
        }

        /// <summary>  
        /// 查找树节点  
        /// </summary>  
        public int Search(int key)
        {
            int index = 1;
            while (index < data.Length && data[index] != 0)
            {
                if (data[index] == key)
                    return index;
                else if (key < data[index])
                {
                    index = LeftChild(index);
                }
                else
                {
                    index = RightChild(index);
                }
            }
            return -1;
        }
        /// <summary>  
        /// 输出树的结构  
        /// </summary>  
        public override string ToString()
        {
            return null;
        }
        /// <summary>  
        /// 先序遍历  
        /// </summary>  
        public void PreOrder(int i)
        {
            if (i >= data.Length)
                return;
            if (data[i] != 0)
            {
                tmpList.Add(data[i]);
                szallall = szallall + data[i] + ",";
            }
            PreOrder(LeftChild(i));
            PreOrder(RightChild(i));

        }
        /// <summary>  
        /// 中序遍历  
        /// </summary>  
        /// <param name="i"></param>  
        public void InOrder(int i)
        {
            if (i >= data.Length)
                return;
            InOrder(LeftChild(i));
            if (data[i] != 0)
            {
                //Console.Write(data[i] + " ");
                szallall = szallall + data[i] + ",";
            }
            InOrder(RightChild(i));
        }
        /// <summary>  
        /// 后续遍历  
        /// </summary>  
        /// <param name="i"></param>  
        public void PostOrder(int i)
        {
            if (i >= data.Length)
                return;
            PostOrder(LeftChild(i));
            PostOrder(RightChild(i));
            if (data[i] != 0)
            {
                //Console.Write(data[i] + " ");
                //MessageBox.Show(data[i] + " ");
                szallall = szallall+data[i] + ",";
            }
        }

   


    public city_tm_2()
        {
            InitializeComponent();
            qg_text1.Text = "28,10,37,63,35,30,23,46";
        }

      
        private void qg_button1_Click(object sender, EventArgs e)
        {

            szallall = "";
            Tree();
            string[] lines_fz = qg_text1.Text.Trim().Split(',');//用|分组

            for (int i = 0; i < lines_fz.Length; i++)
            { Insert(lines_fz[i].ToString().ToInt()); }
            //szallall = "";
            //Tree();
            //Insert(28);
            //Insert(10);
            //Insert(37);
            //Insert(63);
            //Insert(35);
            //Insert(30);
            //Insert(23);
            //Insert(46);

            PreOrder(1);
            qg_text2.Text = szallall;

        }

        private void qg_button2_Click(object sender, EventArgs e)
        {
            szallall = "";
            Tree();
            string[] lines_fz = qg_text1.Text.Trim().Split(',');//用|分组

            for (int i = 0; i < lines_fz.Length; i++)
            { Insert(lines_fz[i].ToString().ToInt()); }
            //szallall = "";
            //Tree();
            //Insert(28);
            //Insert(10);
            //Insert(37);
            //Insert(63);
            //Insert(35);
            //Insert(30);
            //Insert(23);
            //Insert(46);

            InOrder(1);
            qg_text3.Text = szallall;
        }

        private void qg_button3_Click(object sender, EventArgs e)
        {
            szallall = "";
            Tree();
            string[] lines_fz = qg_text1.Text.Trim().Split(',');//用|分组

            for(int i=0;i<lines_fz.Length;i++)
            { Insert(lines_fz[i].ToString().ToInt()); }
            
           
            //Insert(28);
            //Insert(10);
            //Insert(37);
            //Insert(63);
            //Insert(35);
            //Insert(30);
            //Insert(23);
            //Insert(46);

            PostOrder(1);
            qg_text4.Text = szallall;
        }
    }
}
