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
    public partial class Form_gestionCourt_modif : Form
    {
        public Form_gestionCourt_modif(int numCourt)
        {
            int indexCourt = GestionClub.getIndexOfCourt(numCourt);
            InitializeComponent();
            tb_gestionCourt_modif_num.Text = numCourt.ToString();
            tb_gestionCourt_modif_nbPlaces.Text = GestionClub.getTousLesCourts()[indexCourt].getNbPlaces().ToString();
        }

        private void bt_gestionCourt_modif_annuler_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toutes vos modifications vont-être perdues. Êtes vous sûr de vouloir annuler ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form_gestionCourt_modif.ActiveForm.Close();
            }
        }

        private void bt_gestionCourt_modif_valid_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir modifier les informations du Court ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int indexCourt = GestionClub.getIndexOfCourt(Convert.ToInt32(tb_gestionCourt_modif_num.Text));
                //On vérifie que l'utilisateur a bien modifié la valeur avant de faire un setter

                try
                {
                    if (tb_gestionCourt_modif_nbPlaces.Text != GestionClub.getTousLesCourts()[indexCourt].getNbPlaces().ToString())
                    {
                        GestionClub.getTousLesCourts()[indexCourt].setNbPLaces(Convert.ToInt32(tb_gestionCourt_modif_nbPlaces.Text));
                    }
                    MessageBox.Show("La modification a bien été réalisée");
                    Form_gestionCourt_modif.ActiveForm.Close();
                    Form_gestionCourt_Afficher form_gestionCourt_Afficher = new Form_gestionCourt_Afficher();
                    form_gestionCourt_Afficher.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue pendant la modification, veuillez vérifier que tous les champs soient remplis et que ce soit seulement des numériques");
                }
            }
        }
    }
}
