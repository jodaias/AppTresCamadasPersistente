using Basiness;
using DatabaseSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTresCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = tbNome.Text;
            usuario.Telefone = mtbTelefone.Text;
            usuario.CPF = mtbCPF.Text;
            usuario.Gravar();

            MessageBox.Show("Usuário salvo com sucesso");

            tbNome.Text = "";
            mtbTelefone.Text = "";
            mtbCPF.Text = "";
            tbNome.Focus();
        }
    }
}
