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
    public partial class Form_gestionReservation_achat : Form
    {
        public Form_gestionReservation_achat()
        {
            InitializeComponent();
        }

        private void Form_gestionReservation_achat_Load(object sender, EventArgs e)
        {

            #region Loading comboBox choix Adhérent
            //On désactive l'évenement pour ne pas que la méthode SelectedIndexChanged se lance lors du binding au dataSource
            this.cb_gestionReservation_achat_adherent.SelectedIndexChanged -= new EventHandler(cb_gestionReservation_achat_adherent_SelectedIndexChanged);
            
            cb_gestionReservation_achat_adherent.DataSource = GestionClub.getTousLesAdherents();
            cb_gestionReservation_achat_adherent.DisplayMember = "EtatCivil";
            cb_gestionReservation_achat_adherent.ValueMember = "Numero";

            //On désélectionne les valeurs (ici le DataSource séléctionne par défaut la première valeur de la liste)
            cb_gestionReservation_achat_adherent.SelectedIndex = -1;

            //On réactive l'évènement pour pouvoir accéder à la méthode SelectedIndexChanged lors des conditions requises
            this.cb_gestionReservation_achat_adherent.SelectedIndexChanged += new EventHandler(cb_gestionReservation_achat_adherent_SelectedIndexChanged);
            #endregion

            #region Loading comboBox nbPlaces
            int i = 0;
            foreach (int nbPlaces in GestionClub.getParamNbPlacesAchetables())
            {
                cb_gestionReservation_achat_nbPlaces.Items.Add(GestionClub.getParamNbPlacesAchetables()[i]);
                i++;
            }
            #endregion
        }

        private void cb_gestionReservation_achat_adherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On affiche les contrôles relatifs au nombre de places à acheter lorsqu'une valeur est choisie
            cb_gestionReservation_achat_nbPlaces.Visible = true;
            l_gestionReservation_achat_nbPlaces.Visible = true;
            bt_gestionReservation_achat_valider.Visible = true;

        }

        private void bt_gestionReservation_achat_valider_Click(object sender, EventArgs e)
        {
            int index = GestionClub.getIndexOfAdherent(Convert.ToInt32(cb_gestionReservation_achat_adherent.SelectedValue));

            //Lorsque la méthode retourne -1 c'est que l'adhérent n'a pas été trouvé dans la liste avec le numéro fournit
            if (index != -1)
            {
                GestionClub.getTousLesAdherents()[index].setNbReservation(GestionClub.getTousLesAdherents()[index].getNbReservation() + Convert.ToInt32(cb_gestionReservation_achat_nbPlaces.SelectedItem));
                MessageBox.Show(GestionClub.getTousLesAdherents()[index].EtatCivil + " a acheté " + Convert.ToString(cb_gestionReservation_achat_nbPlaces.SelectedItem) + " places" + "\n Places restantes : " + GestionClub.getTousLesAdherents()[index].getNbReservation());
            }
        } 
    }
}
