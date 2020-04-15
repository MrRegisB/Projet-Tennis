namespace GestionTennis
{
    partial class Form_gestionCourt_modif
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
            this.bt_gestionCourt_modif_valid = new System.Windows.Forms.Button();
            this.tb_gestionCourt_modif_nbPlaces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_gestionCourt_modif_num = new System.Windows.Forms.TextBox();
            this.bt_gestionCourt_modif_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionCourt_modif_valid
            // 
            this.bt_gestionCourt_modif_valid.Location = new System.Drawing.Point(74, 281);
            this.bt_gestionCourt_modif_valid.Name = "bt_gestionCourt_modif_valid";
            this.bt_gestionCourt_modif_valid.Size = new System.Drawing.Size(142, 52);
            this.bt_gestionCourt_modif_valid.TabIndex = 5;
            this.bt_gestionCourt_modif_valid.Text = "Valider les modifications ";
            this.bt_gestionCourt_modif_valid.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_modif_valid.Click += new System.EventHandler(this.bt_gestionCourt_modif_valid_Click);
            // 
            // tb_gestionCourt_modif_nbPlaces
            // 
            this.tb_gestionCourt_modif_nbPlaces.Location = new System.Drawing.Point(261, 175);
            this.tb_gestionCourt_modif_nbPlaces.Name = "tb_gestionCourt_modif_nbPlaces";
            this.tb_gestionCourt_modif_nbPlaces.Size = new System.Drawing.Size(155, 22);
            this.tb_gestionCourt_modif_nbPlaces.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de places :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modification des informations du court";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numéro de court (non modifiable)";
            // 
            // tb_gestionCourt_modif_num
            // 
            this.tb_gestionCourt_modif_num.Location = new System.Drawing.Point(261, 116);
            this.tb_gestionCourt_modif_num.Name = "tb_gestionCourt_modif_num";
            this.tb_gestionCourt_modif_num.ReadOnly = true;
            this.tb_gestionCourt_modif_num.Size = new System.Drawing.Size(155, 22);
            this.tb_gestionCourt_modif_num.TabIndex = 8;
            // 
            // bt_gestionCourt_modif_annuler
            // 
            this.bt_gestionCourt_modif_annuler.Location = new System.Drawing.Point(274, 281);
            this.bt_gestionCourt_modif_annuler.Name = "bt_gestionCourt_modif_annuler";
            this.bt_gestionCourt_modif_annuler.Size = new System.Drawing.Size(142, 52);
            this.bt_gestionCourt_modif_annuler.TabIndex = 9;
            this.bt_gestionCourt_modif_annuler.Text = "Annuler ";
            this.bt_gestionCourt_modif_annuler.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_modif_annuler.Click += new System.EventHandler(this.bt_gestionCourt_modif_annuler_Click);
            // 
            // Form_gestionCourt_modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 396);
            this.Controls.Add(this.bt_gestionCourt_modif_annuler);
            this.Controls.Add(this.tb_gestionCourt_modif_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_gestionCourt_modif_valid);
            this.Controls.Add(this.tb_gestionCourt_modif_nbPlaces);
            this.Controls.Add(this.label1);
            this.Name = "Form_gestionCourt_modif";
            this.Text = "Modification du Court";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionCourt_modif_valid;
        private System.Windows.Forms.TextBox tb_gestionCourt_modif_nbPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_gestionCourt_modif_num;
        private System.Windows.Forms.Button bt_gestionCourt_modif_annuler;
    }
}