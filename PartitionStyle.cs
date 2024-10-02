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
    public partial class PartitionStyle : Form
    {
        public PartitionStyle()
        {
            InitializeComponent();
        }

        private void dg_partition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PartitionStyle_Load(object sender, EventArgs e)
        {
            bs_Style.DataSource = Modele.listePartition(); // appel de la méthode listeClients
            bs_Style.DataSource = Modele.listePartition().Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle,
            });
            dgv_partition.DataSource = bs_Style;
            dgv_partition.Columns[0].HeaderText = "Numéro partition";
            dgv_partition.Columns[1].HeaderText = "Libellé partition";
            dgv_partition.Columns[2].HeaderText = "Prix partition";
            dgv_partition.Columns[3].HeaderText = "Numéro style";

        }

        private void bs_Partition2_CurrentChanged(object sender, EventArgs e)
        {
            int IDC = Convert.ToInt32(cb_Partition.SelectedValue);
            int IdPartition = Convert.ToInt32(cb_Partition.SelectedValue);
            bs_Partition.DataSource = Modele.listePartitionParStyle(IdPartition).Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle,
            })
           .OrderBy(x => x.Numpart);
            dgv_partition.DataSource = bs_Partition;
        }

        private void cb_Partition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Partition.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cb_Partition.DisplayMember = "NOMCLI";
            bs_Partition.DataSource = Modele.listeClients();
            cb_Partition.DataSource = bs_Partition;

        }
    }
}
