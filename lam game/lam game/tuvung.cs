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
    class tuvung
    {
        public string englishword;
        public int lengthword;
        public Bitmap hinh;

        public tuvung(string tienganh, int chieudai, Bitmap anh)
        {
            this.englishword = tienganh;
            this.lengthword = chieudai;
            this.hinh = anh;
        }
    }
}
