namespace GestionTennis
{
    partial class Form_gestionReservation_informations
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
            this.bt_gestionReservation_informations_modif = new System.Windows.Forms.Button();
            this.bt_gestionReservation_informations_delete = new System.Windows.Forms.Button();
            this.dgv_gestionReservation_informations = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionReservation_informations_adherent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionReservation_informations_court = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionReservation_informations_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionReservation_informations_nbJoueurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionReservation_informations)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_gestionReservation_informations_modif
            // 
            this.bt_gestionReservation_informations_modif.Location = new System.Drawing.Point(48, 375);
            this.bt_gestionReservation_informations_modif.Name = "bt_gestionReservation_informations_modif";
            this.bt_gestionReservation_informations_modif.Size = new System.Drawing.Size(111, 46);
            this.bt_gestionReservation_informations_modif.TabIndex = 1;
            this.bt_gestionReservation_informations_modif.Text = "Modifier";
            this.bt_gestionReservation_informations_modif.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_informations_modif.Click += new System.EventHandler(this.bt_gestionReservation_informations_modif_Click);
            // 
            // bt_gestionReservation_informations_delete
            // 
            this.bt_gestionReservation_informations_delete.Location = new System.Drawing.Point(268, 375);
            this.bt_gestionReservation_informations_delete.Name = "bt_gestionReservation_informations_delete";
            this.bt_gestionReservation_informations_delete.Size = new System.Drawing.Size(111, 46);
            this.bt_gestionReservation_informations_delete.TabIndex = 2;
            this.bt_gestionReservation_informations_delete.Text = "Supprimer";
            this.bt_gestionReservation_informations_delete.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_informations_delete.Click += new System.EventHandler(this.bt_gestionReservation_informations_delete_Click);
            // 
            // dgv_gestionReservation_informations
            // 
            this.dgv_gestionReservation_informations.AllowUserToAddRows = false;
            this.dgv_gestionReservation_informations.AllowUserToDeleteRows = false;
            this.dgv_gestionReservation_informations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestionReservation_informations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.dgv_gestionReservation_informations_adherent,
            this.dgv_gestionReservation_informations_court,
            this.dgv_gestionReservation_informations_dt,
            this.dgv_gestionReservation_informations_nbJoueurs});
            this.dgv_gestionReservation_informations.Location = new System.Drawing.Point(-3, -6);
            this.dgv_gestionReservation_informations.Name = "dgv_gestionReservation_informations";
            this.dgv_gestionReservation_informations.ReadOnly = true;
            this.dgv_gestionReservation_informations.RowTemplate.Height = 24;
            this.dgv_gestionReservation_informations.Size = new System.Drawing.Size(946, 255);
            this.dgv_gestionReservation_informations.TabIndex = 3;
            // 
            // Numéro
            // 
            this.Numéro.HeaderText = "dgv_gestionReservation_informations_num";
            this.Numéro.Name = "Numéro";
            this.Numéro.ReadOnly = true;
            this.Numéro.Visible = false;
            // 
            // dgv_gestionReservation_informations_adherent
            // 
            this.dgv_gestionReservation_informations_adherent.HeaderText = "Adhérent ";
            this.dgv_gestionReservation_informations_adherent.Name = "dgv_gestionReservation_informations_adherent";
            this.dgv_gestionReservation_informations_adherent.ReadOnly = true;
            // 
            // dgv_gestionReservation_informations_court
            // 
            this.dgv_gestionReservation_informations_court.HeaderText = "Court";
            this.dgv_gestionReservation_informations_court.Name = "dgv_gestionReservation_informations_court";
            this.dgv_gestionReservation_informations_court.ReadOnly = true;
            // 
            // dgv_gestionReservation_informations_dt
            // 
            this.dgv_gestionReservation_informations_dt.HeaderText = "Date et heure";
            this.dgv_gestionReservation_informations_dt.Name = "dgv_gestionReservation_informations_dt";
            this.dgv_gestionReservation_informations_dt.ReadOnly = true;
            // 
            // dgv_gestionReservation_informations_nbJoueurs
            // 
            this.dgv_gestionReservation_informations_nbJoueurs.HeaderText = "Nombre de joueurs";
            this.dgv_gestionReservation_informations_nbJoueurs.Name = "dgv_gestionReservation_informations_nbJoueurs";
            this.dgv_gestionReservation_informations_nbJoueurs.ReadOnly = true;
            // 
            // Form_gestionReservation_informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 508);
            this.Controls.Add(this.dgv_gestionReservation_informations);
            this.Controls.Add(this.bt_gestionReservation_informations_delete);
            this.Controls.Add(this.bt_gestionReservation_informations_modif);
            this.Name = "Form_gestionReservation_informations";
            this.Text = "Informations sur les réservations";
            this.Load += new System.EventHandler(this.Form_gestionReservation_informations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionReservation_informations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionReservation_informations_modif;
        private System.Windows.Forms.Button bt_gestionReservation_informations_delete;
        private System.Windows.Forms.DataGridView dgv_gestionReservation_informations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionReservation_informations_adherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionReservation_informations_court;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionReservation_informations_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionReservation_informations_nbJoueurs;
    }
}