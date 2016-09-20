namespace ADO_NET
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
            this.label_serveur = new System.Windows.Forms.Label();
            this.label_base_de_donees = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_connexion = new System.Windows.Forms.Button();
            this.button_deconnexion = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label_serveur
            // 
            this.label_serveur.AutoSize = true;
            this.label_serveur.Location = new System.Drawing.Point(46, 78);
            this.label_serveur.Name = "label_serveur";
            this.label_serveur.Size = new System.Drawing.Size(50, 13);
            this.label_serveur.TabIndex = 0;
            this.label_serveur.Text = "Serveur :";
            // 
            // label_base_de_donees
            // 
            this.label_base_de_donees.AutoSize = true;
            this.label_base_de_donees.Location = new System.Drawing.Point(46, 131);
            this.label_base_de_donees.Name = "label_base_de_donees";
            this.label_base_de_donees.Size = new System.Drawing.Size(96, 13);
            this.label_base_de_donees.TabIndex = 1;
            this.label_base_de_donees.Text = "Base de données :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(79, 164);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(75, 23);
            this.button_connexion.TabIndex = 4;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // button_deconnexion
            // 
            this.button_deconnexion.Location = new System.Drawing.Point(220, 164);
            this.button_deconnexion.Name = "button_deconnexion";
            this.button_deconnexion.Size = new System.Drawing.Size(87, 23);
            this.button_deconnexion.TabIndex = 5;
            this.button_deconnexion.Text = "Déconnexion";
            this.button_deconnexion.UseVisualStyleBackColor = true;
            this.button_deconnexion.Click += new System.EventHandler(this.button_deconnexion_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(220, 197);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(87, 23);
            this.button_quitter.TabIndex = 6;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etat de la connexion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 280);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 184);
            this.textBox3.TabIndex = 9;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(290, 280);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 184);
            this.vScrollBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 497);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_deconnexion);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_base_de_donees);
            this.Controls.Add(this.label_serveur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_serveur;
        private System.Windows.Forms.Label label_base_de_donees;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.Button button_deconnexion;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

