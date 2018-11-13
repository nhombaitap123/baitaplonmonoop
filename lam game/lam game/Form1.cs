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
using System.Media;
using System.Text.RegularExpressions;

namespace lam_game
{
    public partial class Form1 : Form
    {
        public static int i = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static int sotuvung;
        private static tuvung[] danhsachtu;
        public static Form5 box;
        string tenuser;
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/resource/BackGroundMusic.wav";
            player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 box = new Form1();
            box.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                box = new Form5(txtBox.Text);
                box.ShowDialog();
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 box = new Form2();
            box.ShowDialog();
        }

        private void rANKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 box = new Form3();
            box.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Game ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void sETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 box = new Form6();
            box.ShowDialog();
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 box = new Form7();
            box.ShowDialog();
        }

        private void lOADGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a File to Load";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string chuoitam, chuoiTemp = "           ", nameimage, PathFile; 

                int LengthImage;
                Image hinh;
                StringBuilder ChuoiBuild;
                string chuoidiem;
                using (StreamReader sd = new StreamReader(openFileDialog1.FileName))
                {
                    tenuser = sd.ReadLine();
                    sotuvung = Int32.Parse(sd.ReadLine());
                    danhsachtu = new tuvung[sotuvung];
                    for (int i = 0; i < sotuvung;i++)
                    {
                        int j = 0, k = 0;
                        chuoitam = sd.ReadLine();
                        ChuoiBuild = new StringBuilder(chuoiTemp);
                        while (chuoitam[j] != ' ')
                        {
                            ChuoiBuild[k] = chuoitam[j];
                            k++;
                            j++;
                        }
                        nameimage = ChuoiBuild.ToString();
                        nameimage = Regex.Replace(nameimage, @"\s", "");
                        k = 0;
                        j++;
                        chuoiTemp = "        ";
                        ChuoiBuild = new StringBuilder(chuoiTemp);
                        while (chuoitam[j] != ' ')
                        {
                            ChuoiBuild[k] = chuoitam[j];
                            k++;
                            j++;
                        }
                        LengthImage = Int32.Parse(ChuoiBuild.ToString());
                        k = 0;
                        j++;
                        chuoiTemp = "                                                                                                                                                                                 ";
                        ChuoiBuild = new StringBuilder(chuoiTemp);
                        while (chuoitam[j] != '\t')
                        {
                            ChuoiBuild[k] = chuoitam[j];
                            k++;
                            j++;
                        }
                        PathFile = ChuoiBuild.ToString();
                        hinh = Image.FromFile(PathFile);
                        danhsachtu[i] = new tuvung(nameimage,LengthImage,hinh,PathFile);
                    }
                    chuoidiem = sd.ReadLine();
                }
                box = new Form5(tenuser, sotuvung, danhsachtu,Int32.Parse(chuoidiem));
                box.daload = 1;
                box.ShowDialog();
            }


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
