namespace exo_3_recheche_combo_list
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_choix_fourni = new System.Windows.Forms.Label();
            this.label_commande = new System.Windows.Forms.Label();
            this.listBox_commande = new System.Windows.Forms.ListBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_choix_fourni
            // 
            this.label_choix_fourni.AutoSize = true;
            this.label_choix_fourni.Location = new System.Drawing.Point(64, 59);
            this.label_choix_fourni.Name = "label_choix_fourni";
            this.label_choix_fourni.Size = new System.Drawing.Size(107, 13);
            this.label_choix_fourni.TabIndex = 1;
            this.label_choix_fourni.Text = "Choisir un fournisseur";
            // 
            // label_commande
            // 
            this.label_commande.AutoSize = true;
            this.label_commande.Location = new System.Drawing.Point(64, 172);
            this.label_commande.Name = "label_commande";
            this.label_commande.Size = new System.Drawing.Size(84, 13);
            this.label_commande.TabIndex = 2;
            this.label_commande.Text = "Les commandes";
            // 
            // listBox_commande
            // 
            this.listBox_commande.FormattingEnabled = true;
            this.listBox_commande.Location = new System.Drawing.Point(67, 200);
            this.listBox_commande.Name = "listBox_commande";
            this.listBox_commande.Size = new System.Drawing.Size(209, 95);
            this.listBox_commande.TabIndex = 3;
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(270, 332);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 4;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 367);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.listBox_commande);
            this.Controls.Add(this.label_commande);
            this.Controls.Add(this.label_choix_fourni);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_choix_fourni;
        private System.Windows.Forms.Label label_commande;
        private System.Windows.Forms.ListBox listBox_commande;
        private System.Windows.Forms.Button button_quitter;
    }
}

