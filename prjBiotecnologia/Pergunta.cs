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
    public partial class Pergunta : Form
    {
        SoundPlayer a = new SoundPlayer(System.Environment.CurrentDirectory + "\\acertou.wav");
        SoundPlayer e = new SoundPlayer(System.Environment.CurrentDirectory + "\\errou.wav");
        string[][] perguntas = new string[5][];
        public int aux;
        public int resp;

        public Pergunta()
        {
            InitializeComponent();
        }

        private void Pergunta_Load(object sender, EventArgs e)
        {
            //respostas: 1,3,2,1
            perguntas[0] = new string[] { "O que não é biotecnologia?", "transformação da tecnologia pela Biologia.", "Aplicações que utilizam a vida('bio').", "Processos tecnológicos que transformam a vida.", "Dificuldade: Fácil"};
            perguntas[1] = new string[] { "(UFSM 2015)", "clonagem", "de cruzamentos entre as duas espécies, produzindo um híbrido\n resistente a íons cloreto.", "da transferência para a bactéria não resistente de um plasmídeo \nrecombinante, que contenha o gene de interesse previamente isolado\n da bactéria resistente, produzindo um Organismo Geneticamente Modificado (OGM).", "Dificuldade: Difícil" };
            perguntas[2] = new string[] { "(Unicamp 2014)", "Clonagem", "Manipulação Genética", "Procriação das bactérias", "Dificuldade: Medio"};
            perguntas[3] = new string[] { "(ENEM 2015)", "a sequência de DNA codificante de insulina humana.", "um RNA recombinante de insulina humana.", "a proteína sintetizada por células humanas.", "Dificuldade: Médio" };
            perguntas[4] = new string[] { "", "", "", "", "Dificuldade: TU SE FERROUUU!!!"};
            
            if(aux == 4){
                MessageBox.Show(perguntas[aux][4]);
                this.Dispose();
            }
            else{
            MessageBox.Show(perguntas[aux][4]);
            lbPergunta.Text = perguntas[aux][0];
            rb1.Text = perguntas[aux][1];
            rb2.Text = perguntas[aux][2];
            rb3.Text = perguntas[aux][3];
            }
        }

        private void btConferir_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                if (rb1.Checked == true)
                {
                    acertou();
                }
                else
                {
                    errou();
                }
            }
            else if(aux == 1){
                if (rb3.Checked == true)
                {
                    acertou();
                }
                else
                {
                    errou();
                }
            }
            else if (aux == 2)
            {
                if (rb2.Checked == true)
                {
                    acertou();
                }
                else
                {
                    errou();
                }
            }
            else if (aux == 3)
            {
                if (rb1.Checked == true)
                {
                    acertou();
                }
                else
                {
                    errou();
                }
            }
        }

        private void errou()
        {
            e.PlaySync();
            this.Dispose();
            Form1.musica.Play();
        }

        private void acertou()
        {
            a.PlaySync();
            this.Dispose();
            Form1.musica.Play();
        }
    }
}
