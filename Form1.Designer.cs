namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvClients = new DataGridView();
            bsClients = new BindingSource(components);
            btn_comm = new Button();
            btn_Partition = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 80);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(776, 358);
            dgvClients.TabIndex = 0;
            // 
            // btn_comm
            // 
            btn_comm.Location = new Point(12, 51);
            btn_comm.Name = "btn_comm";
            btn_comm.Size = new Size(80, 23);
            btn_comm.TabIndex = 2;
            btn_comm.Text = "Commande";
            btn_comm.UseVisualStyleBackColor = true;
            btn_comm.Click += btn_comm_Click;
            // 
            // btn_Partition
            // 
            btn_Partition.Location = new Point(98, 51);
            btn_Partition.Name = "btn_Partition";
            btn_Partition.Size = new Size(80, 23);
            btn_Partition.TabIndex = 3;
            btn_Partition.Text = "Partition";
            btn_Partition.UseVisualStyleBackColor = true;
            btn_Partition.Click += btn_Partition_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Partition);
            Controls.Add(btn_comm);
            Controls.Add(dgvClients);
            Name = "Form1";
            Text = "ListeCli";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClients;
        private BindingSource bsClients;
        private Button btn_comm;
        private Button btn_Partition;
    }
}
