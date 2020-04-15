namespace GestionTennis.GestionReservation
{
    partial class Form_gestionReservation_reservation
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
            this.cb_gestionReservation_reservation_adherent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_gestionReservation_reservation_courtDispo = new System.Windows.Forms.Label();
            this.cb_gestionReservation_reservation_court = new System.Windows.Forms.ComboBox();
            this.dtp_gestionReservation_reservation_date = new System.Windows.Forms.DateTimePicker();
            this.l_gestionReservation_reservation_date = new System.Windows.Forms.Label();
            this.l_gestionReservation_reservation_nbJoueurs = new System.Windows.Forms.Label();
            this.cb_gestionReservation_reservation_nbJoueurs = new System.Windows.Forms.ComboBox();
            this.bt_gestionReservation_reservation_valid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_gestionReservation_reservation_adherent
            // 
            this.cb_gestionReservation_reservation_adherent.FormattingEnabled = true;
            this.cb_gestionReservation_reservation_adherent.Location = new System.Drawing.Point(261, 72);
            this.cb_gestionReservation_reservation_adherent.Name = "cb_gestionReservation_reservation_adherent";
            this.cb_gestionReservation_reservation_adherent.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_reservation_adherent.TabIndex = 0;
            this.cb_gestionReservation_reservation_adherent.SelectedIndexChanged += new System.EventHandler(this.cb_gestionReservation_reservation_adherent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adhérent qui réserve :";
            // 
            // l_gestionReservation_reservation_courtDispo
            // 
            this.l_gestionReservation_reservation_courtDispo.AutoSize = true;
            this.l_gestionReservation_reservation_courtDispo.Location = new System.Drawing.Point(40, 171);
            this.l_gestionReservation_reservation_courtDispo.Name = "l_gestionReservation_reservation_courtDispo";
            this.l_gestionReservation_reservation_courtDispo.Size = new System.Drawing.Size(68, 17);
            this.l_gestionReservation_reservation_courtDispo.TabIndex = 2;
            this.l_gestionReservation_reservation_courtDispo.Text = "Court n° :";
            this.l_gestionReservation_reservation_courtDispo.Visible = false;
            // 
            // cb_gestionReservation_reservation_court
            // 
            this.cb_gestionReservation_reservation_court.FormattingEnabled = true;
            this.cb_gestionReservation_reservation_court.Location = new System.Drawing.Point(261, 164);
            this.cb_gestionReservation_reservation_court.Name = "cb_gestionReservation_reservation_court";
            this.cb_gestionReservation_reservation_court.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_reservation_court.TabIndex = 3;
            this.cb_gestionReservation_reservation_court.Visible = false;
            // 
            // dtp_gestionReservation_reservation_date
            // 
            this.dtp_gestionReservation_reservation_date.CustomFormat = "dd/MM/yyyy H:00";
            this.dtp_gestionReservation_reservation_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_gestionReservation_reservation_date.Location = new System.Drawing.Point(261, 121);
            this.dtp_gestionReservation_reservation_date.Name = "dtp_gestionReservation_reservation_date";
            this.dtp_gestionReservation_reservation_date.Size = new System.Drawing.Size(245, 22);
            this.dtp_gestionReservation_reservation_date.TabIndex = 4;
            this.dtp_gestionReservation_reservation_date.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            this.dtp_gestionReservation_reservation_date.Visible = false;
            this.dtp_gestionReservation_reservation_date.ValueChanged += new System.EventHandler(this.dtp_gestionReservation_reservation_date_ValueChanged);
            // 
            // l_gestionReservation_reservation_date
            // 
            this.l_gestionReservation_reservation_date.AutoSize = true;
            this.l_gestionReservation_reservation_date.Location = new System.Drawing.Point(40, 126);
            this.l_gestionReservation_reservation_date.Name = "l_gestionReservation_reservation_date";
            this.l_gestionReservation_reservation_date.Size = new System.Drawing.Size(121, 17);
            this.l_gestionReservation_reservation_date.TabIndex = 5;
            this.l_gestionReservation_reservation_date.Text = "Date réservation :";
            this.l_gestionReservation_reservation_date.Visible = false;
            // 
            // l_gestionReservation_reservation_nbJoueurs
            // 
            this.l_gestionReservation_reservation_nbJoueurs.AutoSize = true;
            this.l_gestionReservation_reservation_nbJoueurs.Location = new System.Drawing.Point(40, 214);
            this.l_gestionReservation_reservation_nbJoueurs.Name = "l_gestionReservation_reservation_nbJoueurs";
            this.l_gestionReservation_reservation_nbJoueurs.Size = new System.Drawing.Size(137, 17);
            this.l_gestionReservation_reservation_nbJoueurs.TabIndex = 6;
            this.l_gestionReservation_reservation_nbJoueurs.Text = "Nombre de joueurs :";
            this.l_gestionReservation_reservation_nbJoueurs.Visible = false;
            // 
            // cb_gestionReservation_reservation_nbJoueurs
            // 
            this.cb_gestionReservation_reservation_nbJoueurs.FormattingEnabled = true;
            this.cb_gestionReservation_reservation_nbJoueurs.Location = new System.Drawing.Point(261, 214);
            this.cb_gestionReservation_reservation_nbJoueurs.Name = "cb_gestionReservation_reservation_nbJoueurs";
            this.cb_gestionReservation_reservation_nbJoueurs.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_reservation_nbJoueurs.TabIndex = 7;
            this.cb_gestionReservation_reservation_nbJoueurs.Visible = false;
            // 
            // bt_gestionReservation_reservation_valid
            // 
            this.bt_gestionReservation_reservation_valid.Location = new System.Drawing.Point(201, 285);
            this.bt_gestionReservation_reservation_valid.Name = "bt_gestionReservation_reservation_valid";
            this.bt_gestionReservation_reservation_valid.Size = new System.Drawing.Size(133, 59);
            this.bt_gestionReservation_reservation_valid.TabIndex = 8;
            this.bt_gestionReservation_reservation_valid.Text = "Valider";
            this.bt_gestionReservation_reservation_valid.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_reservation_valid.Visible = false;
            this.bt_gestionReservation_reservation_valid.Click += new System.EventHandler(this.bt_gestionReservation_reservation_valid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Les courts sont ouvert 24h/24 et 7jours/7";
            // 
            // Form_gestionReservation_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_gestionReservation_reservation_valid);
            this.Controls.Add(this.cb_gestionReservation_reservation_nbJoueurs);
            this.Controls.Add(this.l_gestionReservation_reservation_nbJoueurs);
            this.Controls.Add(this.l_gestionReservation_reservation_date);
            this.Controls.Add(this.dtp_gestionReservation_reservation_date);
            this.Controls.Add(this.cb_gestionReservation_reservation_court);
            this.Controls.Add(this.l_gestionReservation_reservation_courtDispo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_gestionReservation_reservation_adherent);
            this.Name = "Form_gestionReservation_reservation";
            this.Text = "Ajouter une réservation";
            this.Load += new System.EventHandler(this.Form_gestionReservation_reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_gestionReservation_reservation_adherent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_gestionReservation_reservation_courtDispo;
        private System.Windows.Forms.ComboBox cb_gestionReservation_reservation_court;
        private System.Windows.Forms.DateTimePicker dtp_gestionReservation_reservation_date;
        private System.Windows.Forms.Label l_gestionReservation_reservation_date;
        private System.Windows.Forms.Label l_gestionReservation_reservation_nbJoueurs;
        private System.Windows.Forms.ComboBox cb_gestionReservation_reservation_nbJoueurs;
        private System.Windows.Forms.Button bt_gestionReservation_reservation_valid;
        private System.Windows.Forms.Label label2;
    }
}