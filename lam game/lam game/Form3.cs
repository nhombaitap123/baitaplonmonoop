using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lam_game
{
    public partial class Form3 : Form
    {
        private xephang[] danhsachdiem = new xephang[6];
        public Form3()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/New folder/baitaplon/lam game/lam game/data/dulieu.txt"))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int j = 0, k = 0;
                    string ten = "          ", diem = "        ";
                    
                    StringBuilder sb = new StringBuilder(ten);
                    while (line[j] != ' ')
                    {
                        sb[k] = line[j];
                        j++;
                        k++;
                    }
                    ten = sb.ToString();
                    j++;
                    k = 0;

                    StringBuilder sd = new StringBuilder(diem);
                    while (line[j] != ' ') 
                    {
                        sd[k] = line[j];
                        j++;
                        k++;
                    }

                    diem = sd.ToString();
                    danhsachdiem[i] = new xephang(ten, int.Parse(diem));
                    i++;
                }
            }

            Array.Sort(danhsachdiem, delegate(xephang xephang1, xephang xephang2) 
            {
                return xephang1.diem.CompareTo(xephang2.diem);
            });
            listBox1.Items.Add("Thứ hạng\tNgười chơi   Điểm");

            int h = 1;
            foreach (xephang thuhang in danhsachdiem)
            {
                listBox1.Items.Add(h.ToString() + "\t" + thuhang.username + "\t   " + thuhang.diem);
                h++;
            }



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
