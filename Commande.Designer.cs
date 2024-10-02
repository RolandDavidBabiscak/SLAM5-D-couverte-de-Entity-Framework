namespace WinFormsApp1
{
    partial class P_Commande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvCommandes = new DataGridView();
            bsCommandes = new BindingSource(components);
            cb_Clients = new ComboBox();
            bs_Clients2 = new BindingSource(components);
            btn_ajouter = new Button();
            btn_modif = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_Clients2).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(12, 67);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.Size = new Size(776, 371);
            dgvCommandes.TabIndex = 0;
            dgvCommandes.CellContentClick += dgvCommande_CellContentClick;
            // 
            // cb_Clients
            // 
            cb_Clients.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Clients.FormattingEnabled = true;
            cb_Clients.Location = new Point(12, 38);
            cb_Clients.Name = "cb_Clients";
            cb_Clients.Size = new Size(121, 23);
            cb_Clients.TabIndex = 1;
            cb_Clients.SelectedIndexChanged += cb_Clients_SelectedIndexChanged;
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(713, 38);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(75, 23);
            btn_ajouter.TabIndex = 2;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // btn_modif
            // 
            btn_modif.Location = new Point(632, 38);
            btn_modif.Name = "btn_modif";
            btn_modif.Size = new Size(75, 23);
            btn_modif.TabIndex = 3;
            btn_modif.Text = "Modifier";
            btn_modif.UseVisualStyleBackColor = true;
            btn_modif.Click += btn_modif_Click;
            // 
            // P_Commande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_modif);
            Controls.Add(btn_ajouter);
            Controls.Add(cb_Clients);
            Controls.Add(dgvCommandes);
            Name = "P_Commande";
            Text = "Commande";
            Load += P_Commande_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_Clients2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private ComboBox cb_Clients;
        private BindingSource bs_Clients2;
        private Button btn_ajouter;
        private Button btn_modif;
    }
}