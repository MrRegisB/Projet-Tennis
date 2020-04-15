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
    public partial class Form_gestionCourt_add : Form
    {
        public Form_gestionCourt_add()
        {
            InitializeComponent();
        }

        private void bt_gestionCourt_add_valid_Click(object sender, EventArgs e)
        {
            try
            {
                Court c1 = new Court(Convert.ToInt32(bt_gestionCourt_add_nbPlaces.Text));
                //Message qui affiche que l'ajout a bien été effectué en décrémentant le numéro de court car après la création d'un Court il est augmenté
                MessageBox.Show("Le court n°" + (GestionClub.getDernierNumCourt() - 1) + " a bien été ajouté");
            }
            catch
            {
                bt_gestionCourt_add_nbPlaces.Clear();
                MessageBox.Show("Saisie invalide, veuillez saisir un numérique");
            }
            

            
        }
    }
}
