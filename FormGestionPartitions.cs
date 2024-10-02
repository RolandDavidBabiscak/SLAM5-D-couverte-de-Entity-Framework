using System;
using System.Linq;
using System.Windows.Forms;
using SLAM5_TP1.Entities;  // Remplacer par le namespace correct

public partial class FormGestionPartitions : Form
{
    public FormGestionPartitions()
    {
        InitializeComponent();
    }

    private void FormGestionPartitions_Load(object sender, EventArgs e)
    {
        comboBoxStyles.DataSource = Modele.ListeStyles();  // Charge les styles musicaux
        comboBoxStyles.DisplayMember = "NomStyle";
        comboBoxStyles.ValueMember = "ID";

        dgvPartitions.DataSource = Modele.ListePartitions();
        dgvPartitions.Columns["StyleID"].Visible = false;  // Masquer la clé étrangère
        dgvPartitions.Columns["Style"].HeaderText = "Style de Musique";
    }

    private void btnAjouterPartition_Click(object sender, EventArgs e)
    {
        // Ajout d'une partition, similaire à l'ajout de commande
    }
}
