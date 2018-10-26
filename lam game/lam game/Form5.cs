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

using System.Xml;

namespace lam_game
{
    public partial class Form5 : Form
    {
        int n = 0, diemso = 0, mangsong = 3;
        int dem = 0, dem_1 = 0, Next = 0, chieudaiword, dem_hint = 0, vitri = 0;
        private static Random chuoingaunhien = new Random(), songaunhien = new Random();
        private static int[] question = new int[3];
        private static DataGridViewButtonColumn abutton, bbutton, cbutton, dbutton, 
        ebutton, fbutton, gbutton, hbutton, ibutton, jbutton, 
        kbutton, lbutton, mbutton, nbutton, obutton, pbutton, 
        qbutton, rbutton, sbutton, tbutton, ubutton, vbutton, 
        wbutton, xbutton, ybutton, zbutton;
        string tenuser;



        private void btnHint_Click(object sender, EventArgs e)
        {
            if (dem_hint == 3)
            {
                return;
            }
            else
            {
                if (vitri == danhsachword[dem - 1].lengthword)
                    return;
                dem_hint++;
                if (dem_hint == 3)
                    btnHint.Visible = false;
                board.Rows[0].Cells[vitri].Value = danhsachword[dem - 1].englishword[vitri];
                vitri++;
                Next++;
            }
        }

        private void sETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 box = new Form6();
            box.ShowDialog();
        }

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SaveFileDialog savefile = new SaveFileDialog();

        private void sAVEGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile.FileName = "game.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    /////Chua lam truong hop neu dem = 0.
                        sw.WriteLine(danhsachword[dem - 1].englishword + " ");
                        sw.WriteLine(danhsachword[dem - 1].lengthword + " ");
                        sw.WriteLine(danhsachword[dem - 1].hinh.ToString() + " ");
                        sw.WriteLine((dem - 1).ToString());
                }

            }

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Game ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void rANKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 box = new Form3();
            box.ShowDialog();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 box = new Form2();
            box.ShowDialog();
        }

        private static tuvung[] danhsachword;
        Bitmap bgimg;
        string nameimage, chuoitam;
        string[] files;
        int bienthu = 0; //Bien nay chi la tam thoi.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Next--;
            vitri--;
            board.Rows[0].Cells[Next].Value = "";
        }

        public Form5(string nameuser)
        {
            InitializeComponent();
            this.tenuser = nameuser;
        }

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[chuoingaunhien.Next(s.Length)]).ToArray());
        }

        public static string RandomStringresult(int length, string stringresult)
        {
            string chars = stringresult;
            return new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[chuoingaunhien.Next(s.Length)]).ToArray());
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/resource/images");
            danhsachword = new tuvung[100];
            int sorandom = 0;
            for (int i = 0;i < 3; i++)
            {
                while(true)
                {
                    sorandom = songaunhien.Next(0, 3);
                    int k;
                    for (k = 0; k < i; k++)
                    {
                        if (question[k] == sorandom)
                            break;
                    }

                    if (k == i)
                        break;
                }
                question[i] = sorandom;
            }

            int j = 0;
            foreach(int i in question)
            {
                nameimage = Path.GetFileNameWithoutExtension(files[i]);
                chieudaiword = nameimage.Length;
                bgimg = new Bitmap("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/resource/images/" + nameimage + ".bmp");
                danhsachword[j] = new tuvung(nameimage, chieudaiword, bgimg);
                j++;
            }
            vitri = 0;
            if (bienthu != 0)
            {
                if (!checkresult(danhsachword[dem - 1].englishword, xulychuoi()))
                {
                    return;
                }
            }
            else
                bienthu++;

            if (dem_1 == 0)
                dem_1 = 1;

            pictureBox1.Image = danhsachword[dem].hinh;
            n = danhsachword[dem].lengthword;
            InitializeBoard(n);
            InitializeCross(10);
            dem++;
            if (dem == 3)
            {
                bienthu = 0;
                vitri = 0;
            }
            Next = 0;
            using (StreamWriter luuData = new StreamWriter("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/lam game/lam game/data/dulieu.txt"))
            {
                luuData.WriteLine(tenuser + " " + diemso + " ");
            }


        }

        private void InitializeBoard(int n)
        {
            board.BackgroundColor = Color.White;
            board.DefaultCellStyle.BackColor = Color.White;

            for (int i = 0; i < n; i++)
                board.Columns.Add("","");


            foreach (DataGridViewColumn c in board.Columns)
                c.Width = board.Width / board.Columns.Count;

            foreach (DataGridViewRow r in board.Rows)
                r.Height = board.Height / board.Rows.Count;
            
            for(int row = 0;row < board.Rows.Count; row++)
            {
                for (int col = 0; col < board.Columns.Count; col++)
                    board[col, row].ReadOnly = true;
            }
            


        }

        private void InitializeCross(int n)
        {
            cross.BackgroundColor = Color.White;
            cross.DefaultCellStyle.BackColor = Color.White;

            for (int i = 0; i < n; i++)
                cross.Columns.Add("", "");


            foreach (DataGridViewColumn c in cross.Columns)
                c.Width = cross.Width / cross.Columns.Count;

            foreach (DataGridViewRow r in cross.Rows)
                r.Height = cross.Height / cross.Rows.Count;
            
            for (int row = 0; row < cross.Rows.Count; row++)
            {
                for (int col = 0; col < cross.Columns.Count; col++)
                    cross[col, row].ReadOnly = true;
            }
            
            abutton = new DataGridViewButtonColumn();
            abutton.Name = "a";
            abutton.Width = 71;

            cross.Columns.Insert(0, abutton);
            bbutton = new DataGridViewButtonColumn();
            bbutton.Name = "b";
            bbutton.Width = 71;


            cross.Columns.Insert(1, bbutton);
            cbutton = new DataGridViewButtonColumn();
            cbutton.Name = "c";
            cbutton.Width = 71;


            cross.Columns.Insert(2, cbutton);
            dbutton = new DataGridViewButtonColumn();
            dbutton.Name = "d";
            dbutton.Width = 71;

            cross.Columns.Insert(3, dbutton);
            
            ebutton = new DataGridViewButtonColumn();
            ebutton.Name = "e";
            ebutton.Width = 71;

            cross.Columns.Insert(4, ebutton);
            
            fbutton = new DataGridViewButtonColumn();
            fbutton.Name = "f";
            fbutton.Width = 71;

            cross.Columns.Insert(5, fbutton);
            gbutton = new DataGridViewButtonColumn();
            gbutton.Name = "g";
            gbutton.Width = 71;

            cross.Columns.Insert(6, gbutton);
            hbutton = new DataGridViewButtonColumn();
            hbutton.Name = "h";
            hbutton.Width = 71;

            cross.Columns.Insert(7, hbutton);

            ibutton = new DataGridViewButtonColumn();
            ibutton.Name = "i";
            ibutton.Width = 71;

            cross.Columns.Insert(8, ibutton);
            jbutton = new DataGridViewButtonColumn();
            jbutton.Name = "j";
            jbutton.Width = 71;

            cross.Columns.Insert(1, jbutton);
            
            cross.Columns[0].Name = "a";
            cross.Columns[1].Name = "b";
            cross.Columns[2].Name = "c";
            cross.Columns[3].Name = "d";
            cross.Columns[4].Name = "e";
            cross.Columns[5].Name = "f";
            cross.Columns[6].Name = "g";
            cross.Columns[7].Name = "h";
            cross.Columns[8].Name = "i";
            cross.Columns[9].Name = "j";

            string[] rows = new string[] { RandomStringresult(10,danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomStringresult(10, danhsachword[dem].englishword), RandomString(10), RandomString(10), RandomString(10)};
            cross.Rows.Add(rows);
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cross_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cross.Columns["a"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[0].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["b"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[1].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["c"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[2].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["d"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[3].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["e"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[4].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["f"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[5].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["g"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[6].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["h"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[7].Value;
                    Next++;
                    vitri++;
                }

            }
            else if (e.ColumnIndex == cross.Columns["i"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[8].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["j"].Index)
            {
                if (Next < n)
                {
                    board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[9].Value;
                    Next++;
                    vitri++;
                }
            }
            else if (e.ColumnIndex == cross.Columns["k"].Index)
            {
                board.Rows[0].Cells[Next].Value = "k";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["l"].Index)
            {
                board.Rows[0].Cells[Next].Value = "l";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["m"].Index)
            {
                board.Rows[0].Cells[Next].Value = "m";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["n"].Index)
            {
                board.Rows[0].Cells[Next].Value = "n";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["o"].Index)
            {
                board.Rows[0].Cells[Next].Value = "o";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["p"].Index)
            {
                board.Rows[0].Cells[Next].Value = "p";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["q"].Index)
            {
                board.Rows[0].Cells[Next].Value = "q";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["r"].Index)
            {
                board.Rows[0].Cells[Next].Value = "r";
                Next++;
                vitri++;

            }
            else if (e.ColumnIndex == cross.Columns["s"].Index)
            {
                board.Rows[0].Cells[Next].Value = "s";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["t"].Index)
            {
                board.Rows[0].Cells[Next].Value = "t";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["u"].Index)
            {
                board.Rows[0].Cells[Next].Value = "u";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["v"].Index)
            {
                board.Rows[0].Cells[Next].Value = "v";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["w"].Index)
            {
                board.Rows[0].Cells[Next].Value = "w";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["x"].Index)
            {
                board.Rows[0].Cells[Next].Value = "x";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["y"].Index)
            {
                board.Rows[0].Cells[Next].Value = "y";
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["z"].Index)
            {
                board.Rows[0].Cells[Next].Value = "z";
                Next++;
                vitri++;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {            
            if (dem == 3)
            {
                using (StreamWriter sw = new StreamWriter("D:/khoa học máy tính/lập trình hướng đối tượng/bài lab/New folder/baitaplon/lam game/lam game/data/dulieu.txt",true))
                {
                    sw.WriteLine(tenuser + " " + diemso + " ");
                }
                dem = 0;
                diemso = 0;
                diemlabel.Text = diemso.ToString();
                this.Hide();
                Form8 box = new Form8();
                box.ShowDialog();
            }
            vitri = 0;
            if (bienthu != 0)
            {
                if (!checkresult(danhsachword[dem - 1].englishword, xulychuoi()))
                {
                    mangsong--;
                    return;
                }
            }
            else
                bienthu++;

            if (dem_1 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    board.Columns.RemoveAt(0);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                cross.Columns.RemoveAt(0);
            }
            cross.Rows.RemoveAt(0);

            if (dem_1 == 0)
                dem_1 = 1;

            pictureBox1.Image = danhsachword[dem].hinh;
            n = danhsachword[dem].lengthword;
            InitializeBoard(n);
            InitializeCross(10);
            dem++;
            if (dem == 3)
            {
                bienthu = 0;
                vitri = 0;
            }
            Next = 0;
            diemso++;
            diemlabel.Text = diemso.ToString();
                        
        }

        private bool checkresult(string dapan,string ketqua)
        {
            return dapan.Equals(ketqua);
        }

        private string xulychuoi()
        {
            
            chuoitam = " ";
            for (int i = 1; i < n; i++)
                chuoitam += " ";

            StringBuilder sb = new StringBuilder(chuoitam);            
            for(int i = 0; i < n; i++)
            {
                if (board.Rows[0].Cells[i].Value == null)
                    return "";
                sb[i] = board.Rows[0].Cells[i].Value.ToString().ToCharArray()[0];
            }
            chuoitam = sb.ToString();
            return chuoitam;
        }

    }
}
