using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lam_game
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.FormClosed += MainPage_FormClosed;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Form1 again = new Form1();
            this.Hide();
            again.ShowDialog(); 
            this.Close();
        }
    }
}
