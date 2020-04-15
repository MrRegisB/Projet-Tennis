using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionTennis.GestionReservation
{
    public partial class Form_gestionReservation_reservation : Form
    {
        public Form_gestionReservation_reservation()
        {
            InitializeComponent();
        }

        private void Form_gestionReservation_reservation_Load(object sender, EventArgs e)
        {
            #region Loading comboBox Adhérent
            this.cb_gestionReservation_reservation_adherent.SelectedIndexChanged -= new EventHandler(cb_gestionReservation_reservation_adherent_SelectedIndexChanged);
            cb_gestionReservation_reservation_adherent.DataSource = GestionClub.getTousLesAdherents();
            cb_gestionReservation_reservation_adherent.DisplayMember = "EtatCivil";
            cb_gestionReservation_reservation_adherent.ValueMember = "Numero";

            //On désélectionne les valeurs (ici le DataSource séléctionne par défaut la première valeur de la liste)
            cb_gestionReservation_reservation_adherent.SelectedIndex = -1;
            this.cb_gestionReservation_reservation_adherent.SelectedIndexChanged += new EventHandler(cb_gestionReservation_reservation_adherent_SelectedIndexChanged);
            #endregion

            #region Loading comboBox nbJoueurs
            foreach (int nbPlaces in GestionClub.getParamNbJoueursCourt())
            {
                cb_gestionReservation_reservation_nbJoueurs.Items.Add(nbPlaces);
            }
            #endregion
            this.dtp_gestionReservation_reservation_date.ValueChanged -= new EventHandler(dtp_gestionReservation_reservation_date_ValueChanged);
            dtp_gestionReservation_reservation_date.Value = DateTime.Today;
            this.dtp_gestionReservation_reservation_date.ValueChanged += new EventHandler(dtp_gestionReservation_reservation_date_ValueChanged);
        }

        private void bt_gestionReservation_reservation_valid_Click(object sender, EventArgs e)
        {
            if (dtp_gestionReservation_reservation_date.Value < DateTime.Today)
            {
                MessageBox.Show("Date de la réservation inférieure à la date du jour, veuillez la modifier");
            }
            else
            {
                try
                {
                    //On cherche les indexs où sont rangés réspectivement l'Adherent et le Court sélectionnés, dans leur listes
                    int indexAdherent = GestionClub.getIndexOfAdherent(Convert.ToInt32(cb_gestionReservation_reservation_adherent.SelectedValue));
                    int indexCourt = GestionClub.getIndexOfCourt(Convert.ToInt32(cb_gestionReservation_reservation_court.SelectedItem));

                    Reservation reserv1 = new Reservation(GestionClub.getTousLesAdherents()[indexAdherent], GestionClub.getTousLesCourts()[indexCourt], dtp_gestionReservation_reservation_date.Value, Convert.ToInt16(cb_gestionReservation_reservation_nbJoueurs.SelectedItem.ToString()));
                    MessageBox.Show(reserv1.getAdherentReserve().EtatCivil + " a bien réservé le court n° " + reserv1.getCourtReserve().getNumero() + " le " + reserv1.getDtReservation().ToString() + " pour " + reserv1.getNbJoueurs().ToString() + " joueurs.");

                    GestionClub.getTousLesAdherents()[indexAdherent].setNbReservation(GestionClub.getTousLesAdherents()[indexAdherent].getNbReservation() - 1);
                    Form_gestionReservation_reservation.ActiveForm.Close();
                }
                catch
                {
                    //temporaire
                    MessageBox.Show("Erreur lors de la réservation, veuillez vérifier que tous les champs soient correctement remplis");
                }
            }
        }

        private void cb_gestionReservation_reservation_adherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GestionClub.getIndexOfAdherent(Convert.ToInt32(cb_gestionReservation_reservation_adherent.SelectedValue));
            //Si l'adhérent n'a plus de places de réservation
            if (GestionClub.getTousLesAdherents()[index].getNbReservation() == 0)
            {
                MessageBox.Show("L'adhérent " + GestionClub.getTousLesAdherents()[index].EtatCivil + " n'a plus de places, il doit en acheter avant de faire une réservation !");
                //On remet la valeur affichée à vide tout en empêchant l'évènement de se relancer
                this.cb_gestionReservation_reservation_adherent.SelectedIndexChanged -= new EventHandler(cb_gestionReservation_reservation_adherent_SelectedIndexChanged);
                cb_gestionReservation_reservation_adherent.SelectedIndex = -1;
                this.cb_gestionReservation_reservation_adherent.SelectedIndexChanged += new EventHandler(cb_gestionReservation_reservation_adherent_SelectedIndexChanged);
            }
            else
            {
                dtp_gestionReservation_reservation_date.Visible = true;
                l_gestionReservation_reservation_date.Visible = true;
                
            }
            
        }
        
        private void dtp_gestionReservation_reservation_date_ValueChanged(object sender, EventArgs e)
        {
            cb_gestionReservation_reservation_court.Items.Clear();

            
            List<int>courtsDispos = GestionClub.getCourtsDispos(dtp_gestionReservation_reservation_date.Value);

            if (courtsDispos.Count == 0)
            {
                MessageBox.Show("Aucun court dispo à la date/heure séléctionnés");
            }
            else
            {

                foreach (int numCourt in courtsDispos)
                {
                    int indexCourt = GestionClub.getIndexOfCourt(numCourt);
                    cb_gestionReservation_reservation_court.Items.Add(GestionClub.getTousLesCourts()[indexCourt].getNumero());
                }
            }
            cb_gestionReservation_reservation_court.Visible = true;
            l_gestionReservation_reservation_courtDispo.Visible = true;
            cb_gestionReservation_reservation_nbJoueurs.Visible = true;
            l_gestionReservation_reservation_nbJoueurs.Visible = true;
            bt_gestionReservation_reservation_valid.Visible = true;
        }
    }
}
