namespace GestionTennis
{
    partial class Form_gestionCourt
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
            this.bt_gestionCourt_add = new System.Windows.Forms.Button();
            this.bt_gestionCourt_Afficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionCourt_add
            // 
            this.bt_gestionCourt_add.Location = new System.Drawing.Point(132, 65);
            this.bt_gestionCourt_add.Name = "bt_gestionCourt_add";
            this.bt_gestionCourt_add.Size = new System.Drawing.Size(188, 59);
            this.bt_gestionCourt_add.TabIndex = 0;
            this.bt_gestionCourt_add.Text = "Ajouter un court";
            this.bt_gestionCourt_add.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_add.Click += new System.EventHandler(this.bt_gestionCourt_add_Click);
            // 
            // bt_gestionCourt_Afficher
            // 
            this.bt_gestionCourt_Afficher.Location = new System.Drawing.Point(132, 195);
            this.bt_gestionCourt_Afficher.Name = "bt_gestionCourt_Afficher";
            this.bt_gestionCourt_Afficher.Size = new System.Drawing.Size(188, 62);
            this.bt_gestionCourt_Afficher.TabIndex = 1;
            this.bt_gestionCourt_Afficher.Text = "Edition des courts";
            this.bt_gestionCourt_Afficher.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_Afficher.Click += new System.EventHandler(this.bt_gestionCourt_Afficher_Click);
            // 
            // Form_gestionCourt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 405);
            this.Controls.Add(this.bt_gestionCourt_Afficher);
            this.Controls.Add(this.bt_gestionCourt_add);
            this.Name = "Form_gestionCourt";
            this.Text = "Gestion des courts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionCourt_add;
        private System.Windows.Forms.Button bt_gestionCourt_Afficher;
    }
}