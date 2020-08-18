using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplos_while_for
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            //Apresenta o formulario e chama em seguida
            novo.Show();
            //fecha o formulario atual
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2016;

            while (contador >=1950)
            {
                cboAno.Items.Add(contador);
                contador--;

            }
        }
    }
}
