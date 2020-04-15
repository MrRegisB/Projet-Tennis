namespace GestionTennis
{
    partial class Form_gestionAdherent
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
            this.bt_gestionAdherent_Add = new System.Windows.Forms.Button();
            this.bt_gestionAdherent_afficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionAdherent_Add
            // 
            this.bt_gestionAdherent_Add.Location = new System.Drawing.Point(163, 25);
            this.bt_gestionAdherent_Add.Name = "bt_gestionAdherent_Add";
            this.bt_gestionAdherent_Add.Size = new System.Drawing.Size(151, 97);
            this.bt_gestionAdherent_Add.TabIndex = 0;
            this.bt_gestionAdherent_Add.Text = "Ajotuer un adhérent";
            this.bt_gestionAdherent_Add.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent_Add.Click += new System.EventHandler(this.bt_gestionAdherent_Add_Click);
            // 
            // bt_gestionAdherent_afficher
            // 
            this.bt_gestionAdherent_afficher.Location = new System.Drawing.Point(163, 208);
            this.bt_gestionAdherent_afficher.Name = "bt_gestionAdherent_afficher";
            this.bt_gestionAdherent_afficher.Size = new System.Drawing.Size(151, 108);
            this.bt_gestionAdherent_afficher.TabIndex = 2;
            this.bt_gestionAdherent_afficher.Text = "Edition des adhérents";
            this.bt_gestionAdherent_afficher.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent_afficher.Click += new System.EventHandler(this.bt_gestionAdherent_afficher_Click);
            // 
            // Form_gestionAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 399);
            this.Controls.Add(this.bt_gestionAdherent_afficher);
            this.Controls.Add(this.bt_gestionAdherent_Add);
            this.Name = "Form_gestionAdherent";
            this.Text = "Gestion des adhérents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionAdherent_Add;
        private System.Windows.Forms.Button bt_gestionAdherent_afficher;
    }
}