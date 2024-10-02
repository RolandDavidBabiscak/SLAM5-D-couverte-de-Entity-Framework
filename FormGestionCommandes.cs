using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes()
        {
            InitializeComponent();
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            bs_Ajout.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            cb_Ajout.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cb_Ajout.DisplayMember = "NOMCLI";
            bs_Ajout.DataSource = Modele.listeClients();
            cb_Ajout.DataSource = bs_Ajout;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            NumberEntered = false;

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Veuillez saisir uniquement des chiffres");
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Annuler_Click_1(object sender, EventArgs e)
        {
            //FormGestionCommandes formGestionConnandes = new FormGestionCommandes();
            this.Hide();
            //formGestionConnandes.Show();
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Fermer_Click_1(object sender, EventArgs e)
        {
            //FormGestionCommandes formGestionConnandes = new FormGestionCommandes();
            this.Close();
        }
    }
}
