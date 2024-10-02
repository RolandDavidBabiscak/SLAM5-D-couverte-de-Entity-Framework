using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Entities;
//using ;

namespace WinFormsApp1
{
    public partial class FormGestion : Form
    {
        public FormGestion()
        {
            InitializeComponent();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            bs_Ajout.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            cb_Ajout.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cb_Ajout.DisplayMember = "NOMCLI";
            bs_Ajout.DataSource = Modele.listeClients();
            cb_Ajout.DataSource = bs_Ajout;
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            bool NumberEntered = false;

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

            //if (DateTime.Today != dateC())
            //{
            //    MessageBox.Show("Veuillez saisir une date correcte");
            //}
        }

        private void btn_Annuler_Click_1(object sender, EventArgs e)
        {
            FormGestion formGestionConnandes = new FormGestion();
            this.Hide();
            formGestionConnandes.Show();
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {
            //ajoutReussi = false
            //Modele.AjoutCommande(int,DateTime,int);
            //if(ajoutReussi == true)
            //{
            //     MessageBox.Show("L'ajout de la commande est réussi !");
            //     this.Close();
            //}
            //elseif(ajoutReussi == false)
            //{
            //     MessageBox.Show("L'ajout de la commande a été refusé !");
            //}
        }

        private void btn_Fermer_Click_1(object sender, EventArgs e)
        {
            FormGestion formGestionConnandes = new FormGestion();
            this.Close();
        }

        private void cb_Ajout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Ajout.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectioner un client");
            }
        }
    }
}
