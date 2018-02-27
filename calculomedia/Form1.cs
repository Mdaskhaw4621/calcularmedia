using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculomedia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = txbNome.Text;

            Double n_1bim, n_2bim, n_3bim, n_4bim;

            n_1bim = System.Convert.ToDouble(txb1Bim.Text);
            n_2bim = System.Convert.ToDouble(txb2Bim.Text);
            n_3bim = System.Convert.ToDouble(txb3Bim.Text);
            n_4bim = System.Convert.ToDouble(txb4Bim.Text);


            Double media = ((n_1bim + n_2bim + n_3bim + n_4bim) / 4);

            lblExibirNome.Text = "O aluno: " + nome;

            if (media >= 7)
            {
                lblExibirMedia.Text = "Está Aprovado com média final: " + media;
            }
            else if (media < 7)
            {
                lblExibirMedia.Text = "Está Reprovado com média final: " + media;
            }
            
            
        }
    }
}
