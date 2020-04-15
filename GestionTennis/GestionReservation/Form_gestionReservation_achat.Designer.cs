namespace GestionTennis
{
    partial class Form_gestionReservation_achat
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
            this.cb_gestionReservation_achat_adherent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gestionReservation_achat_nbPlaces = new System.Windows.Forms.ComboBox();
            this.l_gestionReservation_achat_nbPlaces = new System.Windows.Forms.Label();
            this.bt_gestionReservation_achat_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_gestionReservation_achat_adherent
            // 
            this.cb_gestionReservation_achat_adherent.FormattingEnabled = true;
            this.cb_gestionReservation_achat_adherent.Location = new System.Drawing.Point(289, 94);
            this.cb_gestionReservation_achat_adherent.Name = "cb_gestionReservation_achat_adherent";
            this.cb_gestionReservation_achat_adherent.Size = new System.Drawing.Size(214, 24);
            this.cb_gestionReservation_achat_adherent.TabIndex = 0;
            this.cb_gestionReservation_achat_adherent.SelectedIndexChanged += new System.EventHandler(this.cb_gestionReservation_achat_adherent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adhérent qui achète les réservations :";
            // 
            // cb_gestionReservation_achat_nbPlaces
            // 
            this.cb_gestionReservation_achat_nbPlaces.FormattingEnabled = true;
            this.cb_gestionReservation_achat_nbPlaces.Location = new System.Drawing.Point(289, 171);
            this.cb_gestionReservation_achat_nbPlaces.Name = "cb_gestionReservation_achat_nbPlaces";
            this.cb_gestionReservation_achat_nbPlaces.Size = new System.Drawing.Size(214, 24);
            this.cb_gestionReservation_achat_nbPlaces.TabIndex = 2;
            this.cb_gestionReservation_achat_nbPlaces.Visible = false;
            // 
            // l_gestionReservation_achat_nbPlaces
            // 
            this.l_gestionReservation_achat_nbPlaces.AutoSize = true;
            this.l_gestionReservation_achat_nbPlaces.Location = new System.Drawing.Point(12, 171);
            this.l_gestionReservation_achat_nbPlaces.Name = "l_gestionReservation_achat_nbPlaces";
            this.l_gestionReservation_achat_nbPlaces.Size = new System.Drawing.Size(131, 17);
            this.l_gestionReservation_achat_nbPlaces.TabIndex = 3;
            this.l_gestionReservation_achat_nbPlaces.Text = "Nombre de places :";
            this.l_gestionReservation_achat_nbPlaces.Visible = false;
            // 
            // bt_gestionReservation_achat_valider
            // 
            this.bt_gestionReservation_achat_valider.Location = new System.Drawing.Point(183, 295);
            this.bt_gestionReservation_achat_valider.Name = "bt_gestionReservation_achat_valider";
            this.bt_gestionReservation_achat_valider.Size = new System.Drawing.Size(160, 72);
            this.bt_gestionReservation_achat_valider.TabIndex = 4;
            this.bt_gestionReservation_achat_valider.Text = "Valider";
            this.bt_gestionReservation_achat_valider.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_achat_valider.Visible = false;
            this.bt_gestionReservation_achat_valider.Click += new System.EventHandler(this.bt_gestionReservation_achat_valider_Click);
            // 
            // Form_gestionReservation_achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 460);
            this.Controls.Add(this.bt_gestionReservation_achat_valider);
            this.Controls.Add(this.l_gestionReservation_achat_nbPlaces);
            this.Controls.Add(this.cb_gestionReservation_achat_nbPlaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_gestionReservation_achat_adherent);
            this.Name = "Form_gestionReservation_achat";
            this.Text = "Achat de reservation";
            this.Load += new System.EventHandler(this.Form_gestionReservation_achat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_gestionReservation_achat_adherent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gestionReservation_achat_nbPlaces;
        private System.Windows.Forms.Label l_gestionReservation_achat_nbPlaces;
        private System.Windows.Forms.Button bt_gestionReservation_achat_valider;
    }
}