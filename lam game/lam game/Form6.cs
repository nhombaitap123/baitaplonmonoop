using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lam_game
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        uint NewVolumeAllChannels;
        int NewVolume, Value, flag = 0;
        //Cái này dành cho chỉnh âm lượng của ứng dụng.
        public static class NativeMethods
        {
            //Winm WindowsSound
            [DllImport("winmm.dll")]
            internal static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
            [DllImport("winmm.dll")]
            internal static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            uint CurrVol = ushort.MaxValue / 10;
            NativeMethods.waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);

            NewVolume = ((ushort.MaxValue / 100) * trackBar1.Value);
            NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            NativeMethods.waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            label1.Text = Convert.ToString("Volume: " + trackBar1.Value + "0 %");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 100) * trackBar1.Value);
            NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            if (flag == 0)
            {
                Value = trackBar1.Value;
                NativeMethods.waveOutSetVolume(IntPtr.Zero, 0);
                label1.Text = Convert.ToString("Volume: 0 %");
                flag++;
            }
            else
            {
                trackBar1.Value = Value;
                NewVolume = ((ushort.MaxValue / 100) * trackBar1.Value);
                NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
                NativeMethods.waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
                label1.Text = Convert.ToString("Volume: " + trackBar1.Value + "0 %");
                flag--;

            }
        }
    }
}
