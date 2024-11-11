using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class GAMEPROGRESS2 : Form
    {
        public GAMEPROGRESS2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            GAMEWIN g = new GAMEWIN();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            GAMEYOUTHINKYOURFUNNY g = new GAMEYOUTHINKYOURFUNNY();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            GAMELOSE g = new GAMELOSE();
            g.Show();
        }
    }
}
