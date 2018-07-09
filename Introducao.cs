using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToppestGame
{
    public partial class ToppestGame : Form
    {
        private int contador = 0;
        private int contAuxiliar = 0;
        private bool estaEscrevendo = false;
        private bool boolAuxiliar = false;

        public ToppestGame()
        {
            InitializeComponent();
        }

        private void ToppestGame_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 550);
            this.CenterToScreen();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToppestGame_Shown(object sender, EventArgs e)
        {
            btnProximo_Click(sender, e);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!estaEscrevendo)
                {
                    switch (contador)
                    {
                        case 0:
                            DefinirMensagemOla();
                            break;
                        case 1:
                            EscreverMensagem("Meu nome é Benjamin Ahola, serei seu guia nesta incrivel jornada");
                            break;
                        case 2:
                            this.Size = new Size(800, this.Height);
                            this.CenterToScreen();
                            txtNome.Enabled = txtNome.Visible = true;
                            lblNome.Enabled = lblNome.Visible = true;
                            txtIdade.Enabled = txtIdade.Visible = true;
                            lblIdade.Enabled = lblIdade.Visible = true;
                            EscreverMensagem("Me diga qual seu nome e a sua idade");
                            break;
                        case 3:
                            ValidarDadosUsuario();

                            txtNome.Enabled = txtNome.Visible = false;
                            lblNome.Enabled = lblNome.Visible = false;
                            txtIdade.Enabled = txtIdade.Visible = false;
                            lblIdade.Enabled = lblIdade.Visible = false;

                            this.Size = new Size(400, this.Height);
                            this.CenterToScreen();
                            EscreverMensagem("certo " + Parametros.Nome + ", clique no meu bumbum para prosseguir");
                            btnBumbum.Enabled = btnBumbum.Visible = true;
                            break;
                        case 4:
                            EscreverMensagem("no bumbum seu analfabeto funcional");
                            break;
                        case 5:
                            if (MessageBox.Show("Você se arrepende dos seus atos?", "se fudeu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                MessageBox.Show("isso nao tem a minima relevancia");
                            }
                            else
                            {
                                MessageBox.Show("kkkkkk jura?");
                            }
                            Application.Exit();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    contador++;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                new ErrorForm().ShowDialog();
            }
        }

        private void ValidarDadosUsuario()
        {
            // Valida o nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                contador = 3;
                throw new ArgumentException("me diz qual seu nome desgraçaaaaaaaaaaa");
            }
            else if (!new Regex(@"^[a-zA-Z\u00C0-\u00FF ]*$").IsMatch(txtNome.Text))
            {
                contador = 3;
                throw new ArgumentException("Jura que seu nome é esse" + Environment.NewLine + "escreve samerda certo");
            }
            else if (txtNome.Text.ToUpper().Equals("IRINEU"))
            {
                if (!boolAuxiliar)
                {
                    MessageBox.Show("você nao sabe nenheu");
                    boolAuxiliar = true;
                }
            }
            Parametros.Nome = txtNome.Text;

            // Valida a idade
            if (string.IsNullOrEmpty(txtIdade.Text))
            {
                contador = 3;
                throw new ArgumentException("o seu otario ta achando q sua idade nao importa????" + Environment.NewLine + "informa essa porra");
            }
            int idade = 0;
            bool idadeInvalida = Int32.TryParse(txtIdade.Text, out idade);
            if (!idadeInvalida)
            {
                contador = 3;
                throw new ArgumentException("informa uma idade certa pelo amor de faustao");
            }
            if (idade < 1)
            {
                contador = 3;
                throw new ArgumentException(idade + "? realy?");
            }
            else if (idade < 18)
            {
                if (MessageBox.Show("Esse conteúdo é proibido para menores de 18 anos. Pode conter linguagem pesada, conteúdo sexual explícito, nudez frequente, violência forte ou cenas explícitas de consumo de drogas. Essa classificação também é usada para conteúdo pornográfico.\r\n\r\nVocê concorda com isso?", "Classificações e controle parental", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("isso nao tem a minima relevancia");
                }
                else
                {
                    MessageBox.Show("kkkkkk jura?");
                }
            }
            else if (Parametros.Idade == 69)
            {
                MessageBox.Show("       ( ͡° ͜ʖ ͡°)");
            }
            else if (Parametros.Idade > 70)
            {
                MessageBox.Show("what the fuuuuuuck como assim");
            }
            Parametros.Idade = idade;
        }

        private void EscreverMensagem(string texto)
        {
            lblMensagem.Text = string.Empty;
            char[] caracteres = texto.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                double seg = 0.05;
                estaEscrevendo = true;
                btnProximo.Visible = false;
                lblMensagem.Text += caracteres[i];
                if (caracteres[i].ToString() == "," || caracteres[i].ToString() == ".")
                {
                    seg *= 10;
                }
                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(seg) > DateTime.Now);
            }
            estaEscrevendo = false;
            btnProximo.Visible = true;
        }

        private void DefinirMensagemOla()
        {
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 12)
                EscreverMensagem("GUTEN MORGEN!");
            else if (DateTime.Now.Hour <= 18)
                EscreverMensagem("GUTEN TAG!");
            else
                EscreverMensagem("GUTEN ABEND!");
        }

        private void btnBumbum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infelizmente, esta versão do jogo só vai até aqui :-(" + Environment.NewLine + "Mas não se preocupe, algum dia eu vou terminá-lo", "Lágrimas, dor e sofrimento");
            Application.Exit();
        }
    }
}
