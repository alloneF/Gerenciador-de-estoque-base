using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Gerenciador_de_estoque_base
{
      



    public partial class gerStq : Form
    {
        public class produto

        {
            public static int id = 1234;
            public static string nome = "pão de alho";
            public static int qtd = 83;
            public static double precoV = 6.99;
            public static double precoC = 2.50;
        };

        public gerStq()
        {
            InitializeComponent();
        }
        public void prodtShow()
        {
                stq.Text = Convert.ToString(produto.qtd);
                ven.Text = Convert.ToString(produto.precoV);
                com.Text = Convert.ToString(produto.precoC);
                gbProd.Text = Convert.ToString(produto.nome);
        }

        public void alerta(string campo)
        {
            MessageBox.Show(this, "Erro! Por favor preencha o campo " + campo + " corretamente.", "Erro!", 0);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chek;

            if (valo.Text == "")
            {
                string campo = "Valor da operação";
                alerta(campo);
            }

            else if (int.TryParse(valo.Text, out chek) == true)
            {
                produto.qtd = Convert.ToInt32(valo.Text) + produto.qtd;
                prodtShow();
            }

            else
            {
                string campo = "Valor da operação";
                alerta(campo);
            }
        }

        private void Tpreco_Click(object sender, EventArgs e)
        {
            if (valo.Text == "")
            {
                string campo = "Valor da operação";
                alerta(campo);
            }

            else if (Convert.ToInt32(valo.Text) < produto.precoC)
            {
                string campo = "Valor da operação";
                alerta(campo);
            }

            else 
            {
                produto.precoV = Convert.ToDouble(valo.Text);
                prodtShow();
            }
        }

        private void vendid_Click(object sender, EventArgs e)
        {
            int chek;

            if (valo.Text == "")
            {
                string campo = "Valor da operação";
                alerta(campo);
            }

            else if (produto.qtd < Convert.ToInt32(valo.Text))
            {
                string campo = "Valor da operação";
                alerta(campo);
            }

            else if (int.TryParse(valo.Text, out chek) == true)
            {
                produto.qtd = produto.qtd - Convert.ToInt32(valo.Text);
                prodtShow();
            }

            else
            {
                string campo = "Valor da operação";
                alerta(campo);
            }
        }

        private void porcura_Click(object sender, EventArgs e)
        {
            if (idprod.Text == Convert.ToString(produto.id))
            {
                prodtShow();
                idprod.Clear();
            }

            else
            {
                string campo = "ID do produto";
                alerta(campo);
            }
        }

        private void stq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
