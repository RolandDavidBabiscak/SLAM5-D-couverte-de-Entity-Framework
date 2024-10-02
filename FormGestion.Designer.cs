namespace WinFormsApp1
{
    partial class FormGestion
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
            textBox1 = new TextBox();
            lbl_Mont = new Label();
            lbl_Date = new Label();
            dateC = new DateTimePicker();
            lbl_Cli = new Label();
            cb_Ajout = new ComboBox();
            btn_Ok = new Button();
            btn_Annuler = new Button();
            btn_Fermer = new Button();
            bs_Ajout = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bs_Ajout).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbl_Mont
            // 
            lbl_Mont.AutoSize = true;
            lbl_Mont.Location = new Point(172, 86);
            lbl_Mont.Name = "lbl_Mont";
            lbl_Mont.Size = new Size(53, 15);
            lbl_Mont.TabIndex = 1;
            lbl_Mont.Text = "Montant";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(182, 142);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(31, 15);
            lbl_Date.TabIndex = 2;
            lbl_Date.Text = "Date";
            // 
            // dateC
            // 
            dateC.Location = new Point(105, 160);
            dateC.Name = "dateC";
            dateC.Size = new Size(200, 23);
            dateC.TabIndex = 3;
            dateC.ValueChanged += dateC_ValueChanged;
            // 
            // lbl_Cli
            // 
            lbl_Cli.AutoSize = true;
            lbl_Cli.Location = new Point(181, 207);
            lbl_Cli.Name = "lbl_Cli";
            lbl_Cli.Size = new Size(38, 15);
            lbl_Cli.TabIndex = 4;
            lbl_Cli.Text = "Client";
            // 
            // cb_Ajout
            // 
            cb_Ajout.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Ajout.FormattingEnabled = true;
            cb_Ajout.Location = new Point(105, 225);
            cb_Ajout.Name = "cb_Ajout";
            cb_Ajout.Size = new Size(200, 23);
            cb_Ajout.TabIndex = 5;
            cb_Ajout.SelectedIndexChanged += cb_Ajout_SelectedIndexChanged;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(37, 364);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 6;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click_1;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Location = new Point(283, 364);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(75, 23);
            btn_Annuler.TabIndex = 7;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click_1;
            // 
            // btn_Fermer
            // 
            btn_Fermer.Location = new Point(159, 364);
            btn_Fermer.Name = "btn_Fermer";
            btn_Fermer.Size = new Size(75, 23);
            btn_Fermer.TabIndex = 8;
            btn_Fermer.Text = "Fermer";
            btn_Fermer.UseVisualStyleBackColor = true;
            btn_Fermer.Click += btn_Fermer_Click_1;
            // 
            // FormGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(btn_Fermer);
            Controls.Add(btn_Annuler);
            Controls.Add(btn_Ok);
            Controls.Add(cb_Ajout);
            Controls.Add(lbl_Cli);
            Controls.Add(dateC);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_Mont);
            Controls.Add(textBox1);
            Name = "FormGestion";
            Text = "FormGestionCommandes";
            ((System.ComponentModel.ISupportInitialize)bs_Ajout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbl_Mont;
        private Label lbl_Date;
        private DateTimePicker dateC;
        private Label lbl_Cli;
        private ComboBox cb_Ajout;
        private Button btn_Ok;
        private Button btn_Annuler;
        private Button btn_Fermer;
        private BindingSource bs_Ajout;
    }
}