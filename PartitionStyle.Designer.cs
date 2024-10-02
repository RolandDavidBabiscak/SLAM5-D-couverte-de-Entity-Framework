namespace WinFormsApp1
{
    partial class PartitionStyle
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
            dgv_partition = new DataGridView();
            cb_Partition = new ComboBox();
            bs_Partition = new BindingSource(components);
            bs_Style = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv_partition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_Partition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_Style).BeginInit();
            SuspendLayout();
            // 
            // dgv_partition
            // 
            dgv_partition.AllowUserToAddRows = false;
            dgv_partition.AllowUserToDeleteRows = false;
            dgv_partition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_partition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_partition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_partition.Location = new Point(12, 67);
            dgv_partition.Name = "dgv_partition";
            dgv_partition.Size = new Size(776, 371);
            dgv_partition.TabIndex = 1;
            dgv_partition.CellContentClick += dg_partition_CellContentClick;
            // 
            // cb_Partition
            // 
            cb_Partition.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Partition.FormattingEnabled = true;
            cb_Partition.Location = new Point(12, 38);
            cb_Partition.Name = "cb_Partition";
            cb_Partition.Size = new Size(121, 23);
            cb_Partition.TabIndex = 2;
            cb_Partition.SelectedIndexChanged += cb_Partition_SelectedIndexChanged;
            // 
            // PartitionStyle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_Partition);
            Controls.Add(dgv_partition);
            Name = "PartitionStyle";
            Text = "PartitionStyle";
            Load += PartitionStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_partition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_Partition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_Style).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_partition;
        private ComboBox cb_Partition;
        private BindingSource bs_Partition;
        private BindingSource bs_Style;
    }
}