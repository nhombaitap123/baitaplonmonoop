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

namespace lam_game
{
    public partial class Form1 : Form
    {
        public static int i = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
//        StreamWriter luuData = new StreamWriter("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/data/dulieu.txt");
        public Form5 box;
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/resource/BackGroundMusic.wav";
            player.Play();
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
                //                i++;
                /*                using (luuData)
                                {
                                    luuData.WriteLine(txtBox.Text + "\n");
                                }*/
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
    }
}
