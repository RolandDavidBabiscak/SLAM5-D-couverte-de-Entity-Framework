using WinFormsApp1.Entities;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
            dgvClients.Columns[0].Visible = false;
            dgvClients.Columns[1].HeaderText = "Nom client";
            dgvClients.Columns[2].HeaderText = "Prénom client";
            dgvClients.Columns[3].HeaderText = "Adresse client";
            dgvClients.Columns[4].HeaderText = "Numéro de telephone";
            dgvClients.Columns[5].Visible = false;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btn_comm_Click(object sender, EventArgs e)
        {
            P_Commande P_Commande = new P_Commande();
            this.Hide();
            P_Commande.Show();
        }

        private void btn_Partition_Click_1(object sender, EventArgs e)
        {
            PartitionStyle partitionStyle = new PartitionStyle();
             this.Hide();
            partitionStyle.Show();

        }
    }
}
