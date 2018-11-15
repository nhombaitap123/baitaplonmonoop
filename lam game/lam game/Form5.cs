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
using System.Reflection;

using System.Xml;

namespace lam_game
{
    public partial class Form5 : Form
    {
        int n = 0, diemso = 0, mangsong = 3, soword;
        int dem = 0, dem_1 = 0, Next = 0, chieudaiword, dem_hint = 0, vitri = 0;
        private static Random chuoingaunhien = new Random(DateTime.UtcNow.Millisecond), songaunhien = new Random(DateTime.UtcNow.Millisecond);
        private static DataGridViewButtonColumn abutton, bbutton, cbutton, dbutton,
        ebutton, fbutton, gbutton, hbutton, ibutton, jbutton;
        private static xephang[] danhsachdiem = new xephang[6];
        private static int[] daysongaunhien = new int[3];
        private static int[] phantumang;
        private static int[] phantuword = new int[10];
        private string PathFile;
        public int daload = 0;
        static String PathSystem = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        int fCount = Directory.GetFiles(PathSystem + "/resource/images", "*", SearchOption.TopDirectoryOnly).Length;
        string tenuser;
        SaveFileDialog savefile = new SaveFileDialog();
        private static tuvung[] danhsachword;
        Image hinh;
        string nameimage, chuoitam;
        string[] files;
        int bienthu = 0;


        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 box = new Form7();
            box.ShowDialog();
        }




        private void btnHint_Click(object sender, EventArgs e)
        {            
            if (vitri == danhsachword[phantumang[dem - 1]].lengthword)
                return;
            dem_hint++;
            if (dem_hint == 3)
            {
                Form11 box = new Form11();
                btnHint.Visible = false;
                box.ShowDialog();
            }
            board.Rows[0].Cells[vitri].Value = danhsachword[phantumang[dem - 1]].englishword[vitri];
            vitri++;
            Next++;            
        }

        private void sETTINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 box = new Form6();
            box.ShowDialog();
        }

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newgame = new Form1();
            this.Hide();
            newgame.ShowDialog();
            this.Close();
        }

        private void sAVEGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile.FileName = "game.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.Title = "Select a File to Save";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine(tenuser);
                    sw.WriteLine((phantumang.Length - dem + 1).ToString());
                    for (int i = dem; i <= phantumang.Length; i++)
                    {
                        sw.WriteLine(danhsachword[phantumang[i - 1]].englishword + " " + danhsachword[phantumang[i - 1]].lengthword + " " + danhsachword[phantumang[i - 1]].PathFile + "\t");
                    }
                    sw.WriteLine(diemso.ToString());
                }
            }
            this.Close();

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Game ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Environment.Exit(1);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Next >= 0 && vitri >= 0)        
            {
                if (Next > 0)
                    Next--;

                if (vitri > 0)
                    vitri--;

                if (Next >= 0 && vitri >= 0)
                    board.Rows[0].Cells[Next].Value = "";
            }
        }

        public Form5(string nameuser)
        {
            InitializeComponent();
            this.tenuser = nameuser;
            phantumang = new int[fCount];
            danhsachword = new tuvung[fCount];
        }

        public Form5(string nameuser, int sotuvung, tuvung[] danhsachtu, int diemso)
        {
            InitializeComponent();
            this.tenuser = nameuser;
            this.soword = sotuvung;
            phantumang = new int[sotuvung];
            danhsachword = danhsachtu;
            this.diemso = diemso;
        }

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[chuoingaunhien.Next(s.Length)]).ToArray());
        }

        public static int RandomNumber(int Length)
        {
            return songaunhien.Next(0, Length);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xaotron(ref int[] mang)
        {
            int temp;
            for (int i = 0;i < mang.Length;i++)
            {
                int j = RandomNumber(mang.Length - 1);
                temp = mang[j];
                mang[j] = mang[i];
                mang[i] = temp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (daload == 0)
            {
                files = Directory.GetFiles(PathSystem + "/resource/images");

                for (int i = 0; i < phantumang.Length; i++)
                {
                    nameimage = Path.GetFileNameWithoutExtension(files[i]);
                    chieudaiword = nameimage.Length;
                    PathFile = PathSystem + "/resource/images/" + nameimage + ".jpg";
                    hinh = Image.FromFile(PathFile);
                    danhsachword[i] = new tuvung(nameimage, chieudaiword, hinh, PathFile);
                }

                for (int i = 0; i < phantumang.Length; i++)
                    phantumang[i] = i;

                for (int i = 0; i < 10; i++)
                    phantuword[i] = i;

                xaotron(ref phantumang);
                xaotron(ref phantuword);

                vitri = 0;
                if (bienthu != 0)
                {
                    if (!checkresult(danhsachword[phantumang[dem - 1]].englishword, xulychuoi()))
                    {
                        return;
                    }
                }
                else
                    bienthu++;

                if (dem_1 == 0)
                    dem_1 = 1;

                pictureBox1.Image = danhsachword[phantumang[dem]].hinh;
                n = danhsachword[phantumang[dem]].lengthword;
                InitializeBoard(n);
                InitializeCross();
                dem++;
                if (dem == 3)
                {
                    bienthu = 0;
                    vitri = 0;
                }
                Next = 0;
                this.FormClosed += MainPage_FormClosed;
            }
            else
            {
                vitri = 0;
                if (bienthu != 0)
                {
                    if (!checkresult(danhsachword[phantumang[dem - 1]].englishword, xulychuoi()))
                    {
                        return;
                    }
                }
                else
                    bienthu++;

                if (dem_1 == 0)
                    dem_1 = 1;

                for (int i = 0; i < phantumang.Length; i++)
                    phantumang[i] = i;

                for (int i = 0; i < 10; i++)
                    phantuword[i] = i;

                xaotron(ref phantuword);
                xaotron(ref phantumang); 

                pictureBox1.Image = danhsachword[phantumang[dem]].hinh;
                n = danhsachword[phantumang[dem]].lengthword;

                InitializeBoard(n); 
                InitializeCross(); 
                dem++;
                if (dem == 3)
                {
                    bienthu = 0;
                    vitri = 0;
                }
                Next = 0;
                diemlabel.Text = diemso.ToString();
                this.FormClosed += MainPage_FormClosed;
            }

        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
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

        private void InitializeCross()
        {
            cross.BackgroundColor = Color.White;
            cross.DefaultCellStyle.BackColor = Color.White;

            for (int i = 0; i < 10; i++)
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

            string[] rows = new string[10];
            int j = 0;

            foreach(int i in phantuword)            
            {
                if (j < n)
                    rows[i] = danhsachword[phantumang[dem]].englishword[j].ToString();
                else
                    rows[i] = RandomString(10);

                j++;
            }

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
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[10].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["l"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[11].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["m"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[12].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["n"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[13].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["o"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[14].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["p"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[15].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["q"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[16].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["r"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[17].Value;
                Next++;
                vitri++;

            }
            else if (e.ColumnIndex == cross.Columns["s"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[18].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["t"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[19].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["u"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[20].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["v"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[21].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["w"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[22].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["x"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[23].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["y"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[24].Value;
                Next++;
                vitri++;
            }
            else if (e.ColumnIndex == cross.Columns["z"].Index)
            {
                board.Rows[0].Cells[Next].Value = cross.Rows[0].Cells[25].Value;
                Next++;
                vitri++;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {            
            if (dem == phantumang.Length)
            {
                xulydiem();
                dem = 0;
                diemso = 0;
                diemlabel.Text = diemso.ToString();
                this.Hide();
                Form8 box = new Form8();
                box.ShowDialog();
                this.Close();
            }

            if (bienthu != 0)
            {
                if (!checkresult(danhsachword[phantumang[dem - 1]].englishword, xulychuoi()))
                {
                    mangsong--;
                    diemso--;
                    if (mangsong == 0)
                    {
                        xulydiem();
                        Form9 box = new Form9();
                        this.Hide();
                        box.ShowDialog();
                    }

                    Form10 box1 = new Form10();
                    box1.ShowDialog();
                    return;
                }
                else
                    vitri = 0;
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

            pictureBox1.Image = danhsachword[phantumang[dem]].hinh;
            n = danhsachword[phantumang[dem]].lengthword;
            InitializeBoard(n);
            InitializeCross();
            dem++;
            if (dem == phantumang.Length)
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
                if (board.Rows[0].Cells[i].Value == null || board.Rows[0].Cells[i].Value.ToString() == "")
                    return "";
                else
                    sb[i] = board.Rows[0].Cells[i].Value.ToString().ToCharArray()[0];
            }
            chuoitam = sb.ToString();
            return chuoitam;
        }

        private void xulydiem()
        {
            using (StreamReader sd = new StreamReader(PathSystem + "/data/dulieu.txt"))
            {
                int i = 0;
                string line;
                while ((line = sd.ReadLine()) != null)
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

                    while (line[j] == ' ')
                        j++;

                    StringBuilder sf = new StringBuilder(diem);
                    while (line[j] != ' ')
                    {
                        sf[k] = line[j];
                        j++;
                        k++;
                    }

                    diem = sf.ToString();
                    danhsachdiem[i] = new xephang(ten, int.Parse(diem));
                    i++;
                }

                danhsachdiem[i] = new xephang(tenuser, diemso + 1);
            }

            Array.Sort(danhsachdiem, delegate (xephang xephang1, xephang xephang2)
            {
                return xephang1.diem.CompareTo(xephang2.diem);
            });


            using (StreamWriter sw = new StreamWriter(PathSystem + "/data/dulieu.txt"))
            {
                for (int i = 5; i > 0; i--)
                    sw.WriteLine(danhsachdiem[i].username + " " + danhsachdiem[i].diem + " ");
            }
        }

    }
}
