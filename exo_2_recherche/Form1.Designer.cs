namespace exo_2_recherche
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_code_fournisseur = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1_cherchez = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.textBox_code_postal = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code fourisseur";
            // 
            // textBox_code_fournisseur
            // 
            this.textBox_code_fournisseur.Location = new System.Drawing.Point(198, 47);
            this.textBox_code_fournisseur.Name = "textBox_code_fournisseur";
            this.textBox_code_fournisseur.Size = new System.Drawing.Size(100, 20);
            this.textBox_code_fournisseur.TabIndex = 1;
            this.textBox_code_fournisseur.TextChanged += new System.EventHandler(this.textBox_code_fournisseur_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1_cherchez
            // 
            this.button1_cherchez.Location = new System.Drawing.Point(335, 38);
            this.button1_cherchez.Name = "button1_cherchez";
            this.button1_cherchez.Size = new System.Drawing.Size(103, 29);
            this.button1_cherchez.TabIndex = 3;
            this.button1_cherchez.Text = "Cherchez";
            this.button1_cherchez.UseVisualStyleBackColor = true;
            this.button1_cherchez.Click += new System.EventHandler(this.button1_cherchez_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_contact);
            this.groupBox1.Controls.Add(this.textBox_ville);
            this.groupBox1.Controls.Add(this.textBox_code_postal);
            this.groupBox1.Controls.Add(this.textBox_nom);
            this.groupBox1.Controls.Add(this.textBox_adresse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(110, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(88, 145);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(211, 20);
            this.textBox_contact.TabIndex = 11;
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(199, 109);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_ville.TabIndex = 10;
            // 
            // textBox_code_postal
            // 
            this.textBox_code_postal.Location = new System.Drawing.Point(88, 109);
            this.textBox_code_postal.Name = "textBox_code_postal";
            this.textBox_code_postal.Size = new System.Drawing.Size(100, 20);
            this.textBox_code_postal.TabIndex = 9;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(88, 26);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(211, 20);
            this.textBox_nom.TabIndex = 5;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(88, 67);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(211, 20);
            this.textBox_adresse.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CP / Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1_cherchez);
            this.Controls.Add(this.textBox_code_fournisseur);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_code_fournisseur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1_cherchez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.TextBox textBox_code_postal;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

