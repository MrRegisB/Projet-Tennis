using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionTennis
{
    public partial class Form_gestionReservation_modif : Form
    {
        public Form_gestionReservation_modif(int numReserv)
        {
            int indexReserv = GestionClub.getIndexOfReserv(numReserv);
            InitializeComponent();
            tb_gestionReservation_modif_num.Text = numReserv.ToString();
            cb_gestionReservation_modif_adherent.ValueMember = GestionClub.getToutesLesReservations()[indexReserv].getAdherentReserve().Numero.ToString();
            dtp_gestionReservation_modif_date.Value = GestionClub.getToutesLesReservations()[indexReserv].getDtReservation();
            cb_gestionReservation_modif_court.Text = GestionClub.getToutesLesReservations()[indexReserv].getCourtReserve().getNumero().ToString();
            cb_gestionReservation_modif_nbJoueurs.Text = GestionClub.getToutesLesReservations()[indexReserv].getNbJoueurs().ToString();
        }

        private void bt_gestionCourt_modif_annuler_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toutes vos modifications vont-être perdues. Êtes vous sûr de vouloir annuler ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form_gestionReservation_modif.ActiveForm.Close();
            }
        }

        private void Form_gestionReservation_modif_Load(object sender, EventArgs e)
        {
            int indexAdherent = GestionClub.getIndexOfAdherent(Convert.ToInt32(cb_gestionReservation_modif_adherent.ValueMember));
            #region Loading comboBox Adhérent

            this.cb_gestionReservation_modif_adherent.SelectedIndexChanged -= new EventHandler(cb_gestionReservation_modif_adherent_SelectedIndexChanged);
            cb_gestionReservation_modif_adherent.DataSource = GestionClub.getTousLesAdherents();
            cb_gestionReservation_modif_adherent.DisplayMember = "EtatCivil";
            cb_gestionReservation_modif_adherent.ValueMember = "Numero";

            //On désélectionne les valeurs (ici le DataSource séléctionne par défaut la première valeur de la liste)
            cb_gestionReservation_modif_adherent.SelectedIndex = indexAdherent;
            this.cb_gestionReservation_modif_adherent.SelectedIndexChanged += new EventHandler(cb_gestionReservation_modif_adherent_SelectedIndexChanged);
            #endregion

            #region Loading comboBox nbJoueurs
            foreach (int nbPlaces in GestionClub.getParamNbJoueursCourt())
            {
                cb_gestionReservation_modif_nbJoueurs.Items.Add(nbPlaces);
            }
            #endregion
        }

        private void cb_gestionReservation_modif_adherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GestionClub.getIndexOfReserv(Convert.ToInt32(cb_gestionReservation_modif_adherent.SelectedValue));
            //Si l'adhérent n'a plus de places de réservation
            if (GestionClub.getTousLesAdherents()[index].getNbReservation() == 0)
            {
                MessageBox.Show("L'adhérent " + GestionClub.getTousLesAdherents()[index].EtatCivil + " n'a plus de places, il doit en acheter avant de faire une réservation !");
                //On remet la valeur affichée à vide tout en empêchant l'évènement de se relancer
                this.cb_gestionReservation_modif_adherent.SelectedIndexChanged -= new EventHandler(cb_gestionReservation_modif_adherent_SelectedIndexChanged);
                cb_gestionReservation_modif_adherent.SelectedIndex = -1;
                this.cb_gestionReservation_modif_adherent.SelectedIndexChanged += new EventHandler(cb_gestionReservation_modif_adherent_SelectedIndexChanged);
            }

        }

        private void dtp_gestionReservation_modif_date_ValueChanged(object sender, EventArgs e)
        {
            int index = GestionClub.getIndexOfReserv(Convert.ToInt32(cb_gestionReservation_modif_adherent.SelectedValue));
            cb_gestionReservation_modif_court.Items.Clear();

            //GestionClub.courtsDispo(cb_gestionReservation_reservation_court, dtp_gestionReservation_reservation_date.Value);
            List<int> courtsDispos = GestionClub.getCourtsDispos(dtp_gestionReservation_modif_date.Value);
            if (courtsDispos.Count > 0)
            {
                foreach (int numCourt in courtsDispos)
                {
                    int indexCourt = GestionClub.getIndexOfCourt(numCourt);
                    cb_gestionReservation_modif_court.Items.Add(GestionClub.getTousLesCourts()[indexCourt].getNumero());
                }
            }
            else
            {
                MessageBox.Show("Auncun courts dispos à cette date/heure exepté celui déjà choisit");
                dtp_gestionReservation_modif_date.Value = GestionClub.getToutesLesReservations()[index].getDtReservation();
            }

        }

        private void bt_gestionReservation_modif_valid_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir modifier la réservation ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int indexReserv = GestionClub.getIndexOfReserv(Convert.ToInt32(tb_gestionReservation_modif_num.Text));
                int indexAdherent = GestionClub.getIndexOfAdherent(Convert.ToInt32(cb_gestionReservation_modif_adherent.SelectedValue));
                int indexCourt = GestionClub.getIndexOfCourt(Convert.ToInt32(cb_gestionReservation_modif_court.Text));
                //On vérifie que l'utilisateur a bien modifié la valeur avant de faire un setter

                try
                {
                    //Si l'adhérent réservatn le terrain a été modifié on décrémente son nb de réservation et on incrémente les réservatio n du précédant réservant
                    if (GestionClub.getTousLesAdherents()[indexAdherent].getNumero().ToString() != tb_gestionReservation_modif_num.Text)
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setNbReservation(GestionClub.getTousLesAdherents()[indexAdherent].getNbReservation() - 1);
                        GestionClub.getTousLesAdherents()[Convert.ToInt32(tb_gestionReservation_modif_num.Text)].setNbReservation(GestionClub.getTousLesAdherents()[Convert.ToInt32(tb_gestionReservation_modif_num.Text)].getNbReservation() + 1);
                    }
                    //Modif adhérent 
                    if (cb_gestionReservation_modif_adherent.SelectedValue.ToString() != GestionClub.getToutesLesReservations()[indexReserv].getAdherentReserve().getNumero().ToString())
                    {
                        GestionClub.getToutesLesReservations()[indexReserv].setAdherentReserve(GestionClub.getTousLesAdherents()[indexAdherent]);
                    }
                    if (dtp_gestionReservation_modif_date.Value != GestionClub.getToutesLesReservations()[indexReserv].getDtReservation())
                    {
                        GestionClub.getToutesLesReservations()[indexReserv].setDtReservation(dtp_gestionReservation_modif_date.Value);
                    }
                    if (cb_gestionReservation_modif_court.Text != GestionClub.getToutesLesReservations()[indexReserv].getCourtReserve().ToString())
                    {
                        GestionClub.getToutesLesReservations()[indexReserv].setCourtReserve(GestionClub.getTousLesCourts()[indexCourt]);
                    }
                    if (cb_gestionReservation_modif_nbJoueurs.Text != GestionClub.getToutesLesReservations()[indexReserv].getNbJoueurs().ToString())
                    {
                        GestionClub.getToutesLesReservations()[indexReserv].setNbJoueurs(Convert.ToInt32(cb_gestionReservation_modif_nbJoueurs.Text));
                    }
                    MessageBox.Show("La modification a bien été réalisée");

                    
                    Form_gestionReservation_modif.ActiveForm.Close();
                    Form_gestionReservation_informations form_getionReservation_infos = new Form_gestionReservation_informations();
                    form_getionReservation_infos.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue pendant la modification, veuillez vérifier que tous les champs soient remplis et que ce soit seulement des numériques");
                }
            }
        }
    }
}
