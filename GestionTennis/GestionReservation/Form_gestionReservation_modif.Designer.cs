namespace GestionTennis
{
    partial class Form_gestionReservation_modif
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt_gestionReservation_modif_valid = new System.Windows.Forms.Button();
            this.cb_gestionReservation_modif_nbJoueurs = new System.Windows.Forms.ComboBox();
            this.l_gestionReservation_modif_nbJoueurs = new System.Windows.Forms.Label();
            this.l_gestionReservation_modif_date = new System.Windows.Forms.Label();
            this.dtp_gestionReservation_modif_date = new System.Windows.Forms.DateTimePicker();
            this.cb_gestionReservation_modif_court = new System.Windows.Forms.ComboBox();
            this.l_gestionReservation_modif_courtDispo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_gestionReservation_modif_adherent = new System.Windows.Forms.ComboBox();
            this.bt_gestionCourt_modif_annuler = new System.Windows.Forms.Button();
            this.tb_gestionReservation_modif_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Modification d\'une réservation";
            // 
            // bt_gestionReservation_modif_valid
            // 
            this.bt_gestionReservation_modif_valid.Location = new System.Drawing.Point(69, 335);
            this.bt_gestionReservation_modif_valid.Name = "bt_gestionReservation_modif_valid";
            this.bt_gestionReservation_modif_valid.Size = new System.Drawing.Size(133, 59);
            this.bt_gestionReservation_modif_valid.TabIndex = 18;
            this.bt_gestionReservation_modif_valid.Text = "Valider les modifications";
            this.bt_gestionReservation_modif_valid.UseVisualStyleBackColor = true;
            this.bt_gestionReservation_modif_valid.Click += new System.EventHandler(this.bt_gestionReservation_modif_valid_Click);
            // 
            // cb_gestionReservation_modif_nbJoueurs
            // 
            this.cb_gestionReservation_modif_nbJoueurs.FormattingEnabled = true;
            this.cb_gestionReservation_modif_nbJoueurs.Location = new System.Drawing.Point(274, 259);
            this.cb_gestionReservation_modif_nbJoueurs.Name = "cb_gestionReservation_modif_nbJoueurs";
            this.cb_gestionReservation_modif_nbJoueurs.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_modif_nbJoueurs.TabIndex = 17;
            // 
            // l_gestionReservation_modif_nbJoueurs
            // 
            this.l_gestionReservation_modif_nbJoueurs.AutoSize = true;
            this.l_gestionReservation_modif_nbJoueurs.Location = new System.Drawing.Point(53, 259);
            this.l_gestionReservation_modif_nbJoueurs.Name = "l_gestionReservation_modif_nbJoueurs";
            this.l_gestionReservation_modif_nbJoueurs.Size = new System.Drawing.Size(137, 17);
            this.l_gestionReservation_modif_nbJoueurs.TabIndex = 16;
            this.l_gestionReservation_modif_nbJoueurs.Text = "Nombre de joueurs :";
            // 
            // l_gestionReservation_modif_date
            // 
            this.l_gestionReservation_modif_date.AutoSize = true;
            this.l_gestionReservation_modif_date.Location = new System.Drawing.Point(53, 171);
            this.l_gestionReservation_modif_date.Name = "l_gestionReservation_modif_date";
            this.l_gestionReservation_modif_date.Size = new System.Drawing.Size(121, 17);
            this.l_gestionReservation_modif_date.TabIndex = 15;
            this.l_gestionReservation_modif_date.Text = "Date réservation :";
            // 
            // dtp_gestionReservation_modif_date
            // 
            this.dtp_gestionReservation_modif_date.CustomFormat = "dd/MM/yyyy H:00";
            this.dtp_gestionReservation_modif_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_gestionReservation_modif_date.Location = new System.Drawing.Point(274, 166);
            this.dtp_gestionReservation_modif_date.Name = "dtp_gestionReservation_modif_date";
            this.dtp_gestionReservation_modif_date.Size = new System.Drawing.Size(245, 22);
            this.dtp_gestionReservation_modif_date.TabIndex = 14;
            this.dtp_gestionReservation_modif_date.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            this.dtp_gestionReservation_modif_date.ValueChanged += new System.EventHandler(this.dtp_gestionReservation_modif_date_ValueChanged);
            // 
            // cb_gestionReservation_modif_court
            // 
            this.cb_gestionReservation_modif_court.FormattingEnabled = true;
            this.cb_gestionReservation_modif_court.Location = new System.Drawing.Point(274, 209);
            this.cb_gestionReservation_modif_court.Name = "cb_gestionReservation_modif_court";
            this.cb_gestionReservation_modif_court.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_modif_court.TabIndex = 13;
            // 
            // l_gestionReservation_modif_courtDispo
            // 
            this.l_gestionReservation_modif_courtDispo.AutoSize = true;
            this.l_gestionReservation_modif_courtDispo.Location = new System.Drawing.Point(53, 216);
            this.l_gestionReservation_modif_courtDispo.Name = "l_gestionReservation_modif_courtDispo";
            this.l_gestionReservation_modif_courtDispo.Size = new System.Drawing.Size(68, 17);
            this.l_gestionReservation_modif_courtDispo.TabIndex = 12;
            this.l_gestionReservation_modif_courtDispo.Text = "Court n° :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adhérent qui réserve :";
            // 
            // cb_gestionReservation_modif_adherent
            // 
            this.cb_gestionReservation_modif_adherent.FormattingEnabled = true;
            this.cb_gestionReservation_modif_adherent.Location = new System.Drawing.Point(274, 117);
            this.cb_gestionReservation_modif_adherent.Name = "cb_gestionReservation_modif_adherent";
            this.cb_gestionReservation_modif_adherent.Size = new System.Drawing.Size(245, 24);
            this.cb_gestionReservation_modif_adherent.TabIndex = 10;
            this.cb_gestionReservation_modif_adherent.SelectedIndexChanged += new System.EventHandler(this.cb_gestionReservation_modif_adherent_SelectedIndexChanged);
            // 
            // bt_gestionCourt_modif_annuler
            // 
            this.bt_gestionCourt_modif_annuler.Location = new System.Drawing.Point(350, 335);
            this.bt_gestionCourt_modif_annuler.Name = "bt_gestionCourt_modif_annuler";
            this.bt_gestionCourt_modif_annuler.Size = new System.Drawing.Size(133, 59);
            this.bt_gestionCourt_modif_annuler.TabIndex = 20;
            this.bt_gestionCourt_modif_annuler.Text = "Annuler";
            this.bt_gestionCourt_modif_annuler.UseVisualStyleBackColor = true;
            this.bt_gestionCourt_modif_annuler.Click += new System.EventHandler(this.bt_gestionCourt_modif_annuler_Click);
            // 
            // tb_gestionReservation_modif_num
            // 
            this.tb_gestionReservation_modif_num.Location = new System.Drawing.Point(0, 0);
            this.tb_gestionReservation_modif_num.Name = "tb_gestionReservation_modif_num";
            this.tb_gestionReservation_modif_num.Size = new System.Drawing.Size(100, 22);
            this.tb_gestionReservation_modif_num.TabIndex = 21;
            this.tb_gestionReservation_modif_num.Visible = false;
            // 
            // Form_gestionReservation_modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 458);
            this.Controls.Add(this.tb_gestionReservation_modif_num);
            this.Controls.Add(this.bt_gestionCourt_modif_annuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_gestionReservation_modif_valid);
            this.Controls.Add(this.cb_gestionReservation_modif_nbJoueurs);
            this.Controls.Add(this.l_gestionReservation_modif_nbJoueurs);
            this.Controls.Add(this.l_gestionReservation_modif_date);
            this.Controls.Add(this.dtp_gestionReservation_modif_date);
            this.Controls.Add(this.cb_gestionReservation_modif_court);
            this.Controls.Add(this.l_gestionReservation_modif_courtDispo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_gestionReservation_modif_adherent);
            this.Name = "Form_gestionReservation_modif";
            this.Text = "Modification Réservation";
            this.Load += new System.EventHandler(this.Form_gestionReservation_modif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_gestionReservation_modif_valid;
        private System.Windows.Forms.ComboBox cb_gestionReservation_modif_nbJoueurs;
        private System.Windows.Forms.Label l_gestionReservation_modif_nbJoueurs;
        private System.Windows.Forms.Label l_gestionReservation_modif_date;
        private System.Windows.Forms.DateTimePicker dtp_gestionReservation_modif_date;
        private System.Windows.Forms.ComboBox cb_gestionReservation_modif_court;
        private System.Windows.Forms.Label l_gestionReservation_modif_courtDispo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gestionReservation_modif_adherent;
        private System.Windows.Forms.Button bt_gestionCourt_modif_annuler;
        private System.Windows.Forms.TextBox tb_gestionReservation_modif_num;
    }
}