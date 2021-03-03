using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_5
{
    public partial class Form1 : Form
    {
        bool Draw;
        int direct;
        int x, y, r;
        public Form1()
        {
            InitializeComponent();
            Draw = false;
            direct = 1;
            x = 0;
            y = 0;
            r = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Draw)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Black), x, y, r, r);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Draw = true;
            this.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (direct)
            {
                case 1:
                    x += 5;
                    y += 5;
                    if (x >= this.ClientSize.Width - 20 || y >= this.ClientSize.Height - 20) direct = 2;
                    break;
                case 2:
                    y -= 5;
                    if (y == 0) direct = 1;
                    if(y == 0 && x >= this.ClientSize.Width - 20) direct = 3;
                    break;
                case 3:
                    x -= 5;
                    y += 5;
                    if (x == 0 || y >= this.ClientSize.Height - 20) direct = 4;
                    break;
                case 4:
                    y -= 5;
                    if (y == 0) direct = 3;
                    if(y == 0 && x == 0) direct = 1;
                    break;
            }

            this.Invalidate();
        }

        private void Стереть_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            x = 0; y = 0;
            Draw = false;
            direct = 1;
            this.Invalidate();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
