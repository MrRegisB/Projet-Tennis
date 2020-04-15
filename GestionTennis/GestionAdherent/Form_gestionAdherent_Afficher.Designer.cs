namespace GestionTennis
{
    partial class Form_gestionAdherent_Afficher
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
            this.dgv_gestionAdherent_Afficher = new System.Windows.Forms.DataGridView();
            this.dgv_gestionAdherent_Afficher_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_ddn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_numTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_dtFinAdhesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionAdherent_Afficher_nbReserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_gestionAdherent_afficher_modify = new System.Windows.Forms.Button();
            this.bt_gestionAdherent_afficher_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionAdherent_Afficher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_gestionAdherent_Afficher
            // 
            this.dgv_gestionAdherent_Afficher.AllowUserToAddRows = false;
            this.dgv_gestionAdherent_Afficher.AllowUserToDeleteRows = false;
            this.dgv_gestionAdherent_Afficher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestionAdherent_Afficher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_gestionAdherent_Afficher_num,
            this.dgv_gestionAdherent_Afficher_nom,
            this.dgv_gestionAdherent_Afficher_prenom,
            this.dgv_gestionAdherent_Afficher_ddn,
            this.dgv_gestionAdherent_Afficher_numTel,
            this.dgv_gestionAdherent_Afficher_mail,
            this.dgv_gestionAdherent_Afficher_classement,
            this.dgv_gestionAdherent_Afficher_dtFinAdhesion,
            this.dgv_gestionAdherent_Afficher_nbReserv});
            this.dgv_gestionAdherent_Afficher.Location = new System.Drawing.Point(0, 0);
            this.dgv_gestionAdherent_Afficher.Name = "dgv_gestionAdherent_Afficher";
            this.dgv_gestionAdherent_Afficher.ReadOnly = true;
            this.dgv_gestionAdherent_Afficher.RowTemplate.Height = 24;
            this.dgv_gestionAdherent_Afficher.Size = new System.Drawing.Size(1353, 365);
            this.dgv_gestionAdherent_Afficher.TabIndex = 0;
            // 
            // dgv_gestionAdherent_Afficher_num
            // 
            this.dgv_gestionAdherent_Afficher_num.HeaderText = "Numéro";
            this.dgv_gestionAdherent_Afficher_num.Name = "dgv_gestionAdherent_Afficher_num";
            this.dgv_gestionAdherent_Afficher_num.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_nom
            // 
            this.dgv_gestionAdherent_Afficher_nom.HeaderText = "Nom";
            this.dgv_gestionAdherent_Afficher_nom.Name = "dgv_gestionAdherent_Afficher_nom";
            this.dgv_gestionAdherent_Afficher_nom.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_prenom
            // 
            this.dgv_gestionAdherent_Afficher_prenom.HeaderText = "Prénom";
            this.dgv_gestionAdherent_Afficher_prenom.Name = "dgv_gestionAdherent_Afficher_prenom";
            this.dgv_gestionAdherent_Afficher_prenom.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_ddn
            // 
            this.dgv_gestionAdherent_Afficher_ddn.HeaderText = "Date de naissance";
            this.dgv_gestionAdherent_Afficher_ddn.Name = "dgv_gestionAdherent_Afficher_ddn";
            this.dgv_gestionAdherent_Afficher_ddn.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_numTel
            // 
            this.dgv_gestionAdherent_Afficher_numTel.HeaderText = "Numéro de téléphone";
            this.dgv_gestionAdherent_Afficher_numTel.Name = "dgv_gestionAdherent_Afficher_numTel";
            this.dgv_gestionAdherent_Afficher_numTel.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_mail
            // 
            this.dgv_gestionAdherent_Afficher_mail.HeaderText = "Adresse mail";
            this.dgv_gestionAdherent_Afficher_mail.Name = "dgv_gestionAdherent_Afficher_mail";
            this.dgv_gestionAdherent_Afficher_mail.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_classement
            // 
            this.dgv_gestionAdherent_Afficher_classement.HeaderText = "Classement";
            this.dgv_gestionAdherent_Afficher_classement.Name = "dgv_gestionAdherent_Afficher_classement";
            this.dgv_gestionAdherent_Afficher_classement.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_dtFinAdhesion
            // 
            this.dgv_gestionAdherent_Afficher_dtFinAdhesion.HeaderText = "Date de fin d\'adhésion";
            this.dgv_gestionAdherent_Afficher_dtFinAdhesion.Name = "dgv_gestionAdherent_Afficher_dtFinAdhesion";
            this.dgv_gestionAdherent_Afficher_dtFinAdhesion.ReadOnly = true;
            // 
            // dgv_gestionAdherent_Afficher_nbReserv
            // 
            this.dgv_gestionAdherent_Afficher_nbReserv.HeaderText = "Nombre de réservations restantes";
            this.dgv_gestionAdherent_Afficher_nbReserv.Name = "dgv_gestionAdherent_Afficher_nbReserv";
            this.dgv_gestionAdherent_Afficher_nbReserv.ReadOnly = true;
            // 
            // bt_gestionAdherent_afficher_modify
            // 
            this.bt_gestionAdherent_afficher_modify.Location = new System.Drawing.Point(79, 397);
            this.bt_gestionAdherent_afficher_modify.Name = "bt_gestionAdherent_afficher_modify";
            this.bt_gestionAdherent_afficher_modify.Size = new System.Drawing.Size(107, 39);
            this.bt_gestionAdherent_afficher_modify.TabIndex = 1;
            this.bt_gestionAdherent_afficher_modify.Text = "Modifier";
            this.bt_gestionAdherent_afficher_modify.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent_afficher_modify.Click += new System.EventHandler(this.bt_gestionAdherent_afficher_modify_Click);
            // 
            // bt_gestionAdherent_afficher_delete
            // 
            this.bt_gestionAdherent_afficher_delete.Location = new System.Drawing.Point(248, 397);
            this.bt_gestionAdherent_afficher_delete.Name = "bt_gestionAdherent_afficher_delete";
            this.bt_gestionAdherent_afficher_delete.Size = new System.Drawing.Size(109, 39);
            this.bt_gestionAdherent_afficher_delete.TabIndex = 2;
            this.bt_gestionAdherent_afficher_delete.Text = "Supprimer";
            this.bt_gestionAdherent_afficher_delete.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent_afficher_delete.Click += new System.EventHandler(this.bt_gestionAdherent_afficher_delete_Click);
            // 
            // Form_gestionAdherent_Afficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 465);
            this.Controls.Add(this.bt_gestionAdherent_afficher_delete);
            this.Controls.Add(this.bt_gestionAdherent_afficher_modify);
            this.Controls.Add(this.dgv_gestionAdherent_Afficher);
            this.Name = "Form_gestionAdherent_Afficher";
            this.Text = "Tous les adhérents";
            this.Load += new System.EventHandler(this.Form_gestionAdherent_Afficher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionAdherent_Afficher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_gestionAdherent_Afficher;
        private System.Windows.Forms.Button bt_gestionAdherent_afficher_modify;
        private System.Windows.Forms.Button bt_gestionAdherent_afficher_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_ddn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_numTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_dtFinAdhesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionAdherent_Afficher_nbReserv;
    }
}