using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form3 : Form
    {
        int lar = 100;
        int click = 0;
        int click2 = 0;
        int alt = 100;
        public Form3()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lar = lar + 2;
            alt = alt + 2;

            click = click + 1;
            pictureBox1.Size = new Size(alt, lar);
            label3.Text = ("Apertou " + click + " " + " para aumentar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lar = lar - 2;
            alt = alt - 2;

            click2 = click2 + 1;
            pictureBox1.Size = new Size(alt, lar);
            label3.Text = ("apertou " + click2 + " " + " para diminuir");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

