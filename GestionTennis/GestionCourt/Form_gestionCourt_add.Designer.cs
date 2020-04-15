namespace GestionTennis
{
    partial class Form_gestionCourt_add
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
            this.bt_gestionCourt_add_nbPlaces = new System.Windows.Forms.TextBox();
            this.bt_gestionCourt_add_valid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de places :";
            // 
            // bt_gestionCourt_add_nbPlaces
            // 
            this.bt_gestionCourt_add_nbPlaces.Location = new System.Drawing.Point(171, 100);
            this.bt_gestionCourt_add_nbPlaces.Name = "bt_gestionCourt_add_nbPlaces";
            this.bt_gestionCourt_add_nbPlaces.Size = new System.Drawing.Size(100, 22);
            this.bt_gestionCourt_add_nbPlaces.TabIndex = 1;
            // 
            // bt_gestionCourt_add_valid
            // 
            this.bt_gestionCourt_add_valid.Location = new System.Drawing.Point(140, 190);
            this.bt_gestionCourt_add_valid.Name = "bt_gestionCourt_add_valid";
            this.bt_gestionCourt_add_valid.Size = new System.Drawing.Size(87, 32);
            this.bt_gestionCourt_add_valid.TabIndex = 2;
            this.bt_gestionCourt_add_valid.Text = "Valider";
            this.bt_gestionCourt_add_valid.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_add_valid.Click += new System.EventHandler(this.bt_gestionCourt_add_valid_Click);
            // 
            // Form_gestionCourt_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 389);
            this.Controls.Add(this.bt_gestionCourt_add_valid);
            this.Controls.Add(this.bt_gestionCourt_add_nbPlaces);
            this.Controls.Add(this.label1);
            this.Name = "Form_gestionCourt_add";
            this.Text = "Ajouter un court";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bt_gestionCourt_add_nbPlaces;
        private System.Windows.Forms.Button bt_gestionCourt_add_valid;
    }
}