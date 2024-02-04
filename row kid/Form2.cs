using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace row_kid
{
    public partial class Form2 : Form
    {
        int player1 = 0;
        int movex = 3;
        int movey = 3;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pictureBox1.Left -= 5;
            }
            if (e.KeyCode == Keys.B)
            {
                pictureBox1.Left += 5;
            }
            






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

