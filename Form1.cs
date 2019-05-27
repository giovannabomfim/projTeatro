using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projTeatroWF
{
    public partial class Form1 : Form
    {

        private Button[] button1;

        public void clicouNoBotao(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no " + ((Button)sender).Text);
        }

        public void inicializaComponentes()
        {
            this.button1 = new Button[10];
            for (int i = 0; i < 10; ++i)
            {
                this.button1[i] = new Button();
                this.button1[i].Parent = this;
                this.button1[i].Left = 100;
                this.button1[i].Top = (int)(50*((double)i/2));
                this.button1[i].Text = "Botão " + (i+1).ToString();
                this.button1[i].Click += new EventHandler(clicouNoBotao);
            }
        }

        public Form1()
        {
            InitializeComponent();
            inicializaComponentes();
        }
    }
}
