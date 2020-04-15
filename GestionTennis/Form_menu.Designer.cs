namespace GestionTennis
{
    partial class Form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.bt_gestionAdherent = new System.Windows.Forms.Button();
            this.bt_gestionCourts = new System.Windows.Forms.Button();
            this.bt_gestionReservation = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gestionAdherent
            // 
            this.bt_gestionAdherent.Location = new System.Drawing.Point(493, 81);
            this.bt_gestionAdherent.Name = "bt_gestionAdherent";
            this.bt_gestionAdherent.Size = new System.Drawing.Size(401, 50);
            this.bt_gestionAdherent.TabIndex = 0;
            this.bt_gestionAdherent.Text = "Gestion des adhérents";
            this.bt_gestionAdherent.UseVisualStyleBackColor = true;
            this.bt_gestionAdherent.Click += new System.EventHandler(this.bt_gestionAdherent_Click);
            // 
            // bt_gestionCourts
            // 
            this.bt_gestionCourts.Location = new System.Drawing.Point(493, 160);
            this.bt_gestionCourts.Name = "bt_gestionCourts";
            this.bt_gestionCourts.Size = new System.Drawing.Size(401, 56);
            this.bt_gestionCourts.TabIndex = 1;
            this.bt_gestionCourts.Text = "Gestion des Courts";
            this.bt_gestionCourts.UseVisualStyleBackColor = true;
            this.bt_gestionCourts.Click += new System.EventHandler(this.bt_gestionCourts_Click);
            // 
            // bt_gestionReservation
            // 
            this.bt_gestionReservation.Location = new System.Drawing.Point(493, 274);
            this.bt_gestionReservation.Name = "bt_gestionReservation";
            this.bt_gestionReservation.Size = new System.Drawing.Size(401, 59);
            this.bt_gestionReservation.TabIndex = 2;
            this.bt_gestionReservation.Text = "Gestion des réservations";
            this.bt_gestionReservation.UseVisualStyleBackColor = true;
            this.bt_gestionReservation.Click += new System.EventHandler(this.bt_gestionReservation_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(493, 381);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(401, 62);
            this.bt_quitter.TabIndex = 3;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1391, 560);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_gestionReservation);
            this.Controls.Add(this.bt_gestionCourts);
            this.Controls.Add(this.bt_gestionAdherent);
            this.Name = "Form_menu";
            this.Text = "Gestion club de Tennis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gestionAdherent;
        private System.Windows.Forms.Button bt_gestionCourts;
        private System.Windows.Forms.Button bt_gestionReservation;
        private System.Windows.Forms.Button bt_quitter;
    }
}

