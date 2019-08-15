using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBiotecnologia
{
    public partial class Form1 : Form
    {
        static public SoundPlayer musica = new System.Media.SoundPlayer(System.Environment.CurrentDirectory + "\\song2.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.aux = 0;
            p.ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.aux = 1;
            p.ShowDialog();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.aux = 4;
            p.ShowDialog();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.aux = 2;
            p.ShowDialog();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Pergunta p = new Pergunta();
            p.aux = 3;
            p.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musica.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
