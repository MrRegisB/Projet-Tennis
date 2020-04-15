namespace GestionTennis
{
    partial class Form_gestionReservation
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
            this.bt_gestionReservation_achat = new System.Windows.Forms.Button();
            this.bt_gestionReservation_reservation = new System.Windows.Forms.Button();
            this.bt_gestionReservation_informations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionReservation_achat
            // 
            this.bt_gestionReservation_achat.Location = new System.Drawing.Point(178, 41);
            this.bt_gestionReservation_achat.Name = "bt_gestionReservation_achat";
            this.bt_gestionReservation_achat.Size = new System.Drawing.Size(136, 35);
            this.bt_gestionReservation_achat.TabIndex = 0;
            this.bt_gestionReservation_achat.Text = "Achat de places";
            this.bt_gestionReservation_achat.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_achat.Click += new System.EventHandler(this.bt_gestionReservation_achat_Click);
            // 
            // bt_gestionReservation_reservation
            // 
            this.bt_gestionReservation_reservation.Location = new System.Drawing.Point(178, 108);
            this.bt_gestionReservation_reservation.Name = "bt_gestionReservation_reservation";
            this.bt_gestionReservation_reservation.Size = new System.Drawing.Size(136, 35);
            this.bt_gestionReservation_reservation.TabIndex = 1;
            this.bt_gestionReservation_reservation.Text = "Reservation";
            this.bt_gestionReservation_reservation.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_reservation.Click += new System.EventHandler(this.bt_gestionReservation_reservation_Click);
            // 
            // bt_gestionReservation_informations
            // 
            this.bt_gestionReservation_informations.Location = new System.Drawing.Point(178, 170);
            this.bt_gestionReservation_informations.Name = "bt_gestionReservation_informations";
            this.bt_gestionReservation_informations.Size = new System.Drawing.Size(136, 61);
            this.bt_gestionReservation_informations.TabIndex = 2;
            this.bt_gestionReservation_informations.Text = "Edition des réservations ";
            this.bt_gestionReservation_informations.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_informations.Click += new System.EventHandler(this.bt_gestionReservation_informations_Click);
            // 
            // Form_gestionReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 358);
            this.Controls.Add(this.bt_gestionReservation_informations);
            this.Controls.Add(this.bt_gestionReservation_reservation);
            this.Controls.Add(this.bt_gestionReservation_achat);
            this.Name = "Form_gestionReservation";
            this.Text = "Gestion des réservations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionReservation_achat;
        private System.Windows.Forms.Button bt_gestionReservation_reservation;
        private System.Windows.Forms.Button bt_gestionReservation_informations;
    }
}