namespace exo_4_insertion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_code_postal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.bouton_ajouter = new System.Windows.Forms.Button();
            this.bouton_quitter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_satisf = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_satisf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(50, 85);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(462, 20);
            this.textBox_nom.TabIndex = 1;
            this.textBox_nom.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_nom_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(50, 172);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(462, 78);
            this.textBox_adresse.TabIndex = 3;
            this.textBox_adresse.TextChanged += new System.EventHandler(this.textBox_adresse_TextChanged);
            this.textBox_adresse.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_adresse_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code Postal";
            // 
            // textBox_code_postal
            // 
            this.textBox_code_postal.Location = new System.Drawing.Point(50, 303);
            this.textBox_code_postal.Name = "textBox_code_postal";
            this.textBox_code_postal.Size = new System.Drawing.Size(153, 20);
            this.textBox_code_postal.TabIndex = 5;
            this.textBox_code_postal.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_code_postal_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville";
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(253, 303);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(259, 20);
            this.textBox_ville.TabIndex = 7;
            this.textBox_ville.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ville_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(50, 382);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(462, 20);
            this.textBox_contact.TabIndex = 9;
            this.textBox_contact.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_contact_Validating);
            // 
            // bouton_ajouter
            // 
            this.bouton_ajouter.Location = new System.Drawing.Point(437, 499);
            this.bouton_ajouter.Name = "bouton_ajouter";
            this.bouton_ajouter.Size = new System.Drawing.Size(75, 23);
            this.bouton_ajouter.TabIndex = 10;
            this.bouton_ajouter.Text = "Ajouter";
            this.bouton_ajouter.UseVisualStyleBackColor = true;
            this.bouton_ajouter.Click += new System.EventHandler(this.bouton_ajouter_Click);
            // 
            // bouton_quitter
            // 
            this.bouton_quitter.Location = new System.Drawing.Point(526, 499);
            this.bouton_quitter.Name = "bouton_quitter";
            this.bouton_quitter.Size = new System.Drawing.Size(75, 23);
            this.bouton_quitter.TabIndex = 11;
            this.bouton_quitter.Text = "Quitter";
            this.bouton_quitter.UseVisualStyleBackColor = true;
            this.bouton_quitter.Click += new System.EventHandler(this.bouton_quitter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Indice de satisfaction";
            // 
            // trackBar_satisf
            // 
            this.trackBar_satisf.Location = new System.Drawing.Point(117, 436);
            this.trackBar_satisf.Name = "trackBar_satisf";
            this.trackBar_satisf.Size = new System.Drawing.Size(404, 45);
            this.trackBar_satisf.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 534);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_satisf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bouton_quitter);
            this.Controls.Add(this.bouton_ajouter);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_code_postal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_satisf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_code_postal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Button bouton_ajouter;
        private System.Windows.Forms.Button bouton_quitter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_satisf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

