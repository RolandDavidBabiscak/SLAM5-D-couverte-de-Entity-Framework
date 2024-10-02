using System;
using System.Linq;
using System.Windows.Forms;
using SLAM5_TP1.Entities;  // Remplacer par le namespace correct

public partial class FormGestionCommandes : Form
{
    public FormGestionCommandes()
    {
        InitializeComponent();
    }

    // Événement pour charger la liste des clients et partitions
    private void FormGestionCommandes_Load(object sender, EventArgs e)
    {
        comboBoxClients.DataSource = Modele.ListeClients();
        comboBoxClients.DisplayMember = "Nomcli";
        comboBoxClients.ValueMember = "Numcli";

        listBoxPartitions.DataSource = Modele.ListePartitions();
        listBoxPartitions.DisplayMember = "Libpart";
        listBoxPartitions.ValueMember = "Numpart";
    }

    // Événement pour ajouter une commande
    private void btnAjouter_Click(object sender, EventArgs e)
    {
        decimal montant = numericMontant.Value;
        DateTime dateC = dateTimePicker.Value;
        int idClient = (int)comboBoxClients.SelectedValue;

        var selectedPartitions = listBoxPartitions.SelectedItems.Cast<Partition>().Select(p => p.Numpart).ToList();

        if (Modele.AjoutCommande(montant, dateC, idClient, selectedPartitions))
        {
            MessageBox.Show("Commande ajoutée avec succès !");
        }
        else
        {
            MessageBox.Show("Erreur lors de l'ajout de la commande.");
        }
    }
}
