namespace GestionTennis
{
    partial class Form_gestionCourt_Afficher
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
            this.dgv_gestionCourt_afficher = new System.Windows.Forms.DataGridView();
            this.dgv_gestionCourt_afficher_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gestionCourt_afficher_nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_gestionCourt_afficher_modif = new System.Windows.Forms.Button();
            this.bt_gestionCourt_afficher_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionCourt_afficher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_gestionCourt_afficher
            // 
            this.dgv_gestionCourt_afficher.AllowUserToAddRows = false;
            this.dgv_gestionCourt_afficher.AllowUserToDeleteRows = false;
            this.dgv_gestionCourt_afficher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gestionCourt_afficher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_gestionCourt_afficher_num,
            this.dgv_gestionCourt_afficher_nbPlaces});
            this.dgv_gestionCourt_afficher.Location = new System.Drawing.Point(-2, -6);
            this.dgv_gestionCourt_afficher.Name = "dgv_gestionCourt_afficher";
            this.dgv_gestionCourt_afficher.ReadOnly = true;
            this.dgv_gestionCourt_afficher.RowTemplate.Height = 24;
            this.dgv_gestionCourt_afficher.Size = new System.Drawing.Size(595, 291);
            this.dgv_gestionCourt_afficher.TabIndex = 0;
            // 
            // dgv_gestionCourt_afficher_num
            // 
            this.dgv_gestionCourt_afficher_num.HeaderText = "Numéro ";
            this.dgv_gestionCourt_afficher_num.Name = "dgv_gestionCourt_afficher_num";
            this.dgv_gestionCourt_afficher_num.ReadOnly = true;
            // 
            // dgv_gestionCourt_afficher_nbPlaces
            // 
            this.dgv_gestionCourt_afficher_nbPlaces.HeaderText = "Nombre de places";
            this.dgv_gestionCourt_afficher_nbPlaces.Name = "dgv_gestionCourt_afficher_nbPlaces";
            this.dgv_gestionCourt_afficher_nbPlaces.ReadOnly = true;
            // 
            // bt_gestionCourt_afficher_modif
            // 
            this.bt_gestionCourt_afficher_modif.Location = new System.Drawing.Point(26, 320);
            this.bt_gestionCourt_afficher_modif.Name = "bt_gestionCourt_afficher_modif";
            this.bt_gestionCourt_afficher_modif.Size = new System.Drawing.Size(111, 32);
            this.bt_gestionCourt_afficher_modif.TabIndex = 1;
            this.bt_gestionCourt_afficher_modif.Text = "Modifier";
            this.bt_gestionCourt_afficher_modif.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_afficher_modif.Click += new System.EventHandler(this.bt_gestionCourt_afficher_modif_Click);
            // 
            // bt_gestionCourt_afficher_delete
            // 
            this.bt_gestionCourt_afficher_delete.Location = new System.Drawing.Point(277, 320);
            this.bt_gestionCourt_afficher_delete.Name = "bt_gestionCourt_afficher_delete";
            this.bt_gestionCourt_afficher_delete.Size = new System.Drawing.Size(107, 32);
            this.bt_gestionCourt_afficher_delete.TabIndex = 2;
            this.bt_gestionCourt_afficher_delete.Text = "Supprimer";
            this.bt_gestionCourt_afficher_delete.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_afficher_delete.Click += new System.EventHandler(this.bt_gestionCourt_afficher_delete_Click);
            // 
            // Form_gestionCourt_Afficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.bt_gestionCourt_afficher_delete);
            this.Controls.Add(this.bt_gestionCourt_afficher_modif);
            this.Controls.Add(this.dgv_gestionCourt_afficher);
            this.Name = "Form_gestionCourt_Afficher";
            this.Text = "Afficher tous les courts";
            this.Load += new System.EventHandler(this.Form_gestionCourt_Afficher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gestionCourt_afficher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_gestionCourt_afficher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionCourt_afficher_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gestionCourt_afficher_nbPlaces;
        private System.Windows.Forms.Button bt_gestionCourt_afficher_modif;
        private System.Windows.Forms.Button bt_gestionCourt_afficher_delete;
    }
}