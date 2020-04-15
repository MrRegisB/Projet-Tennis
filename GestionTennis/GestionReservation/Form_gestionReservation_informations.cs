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
    public partial class Form_gestionReservation_informations : Form
    {
        public Form_gestionReservation_informations()
        {
            InitializeComponent();
        }

        private void Form_gestionReservation_informations_Load(object sender, EventArgs e)
        {
            foreach (Reservation uneReservation in GestionClub.getToutesLesReservations())
            {
                dgv_gestionReservation_informations.Rows.Add(uneReservation.getNumeroReservation(), uneReservation.getAdherentReserve().EtatCivil, uneReservation.getCourtReserve().getNumero(), uneReservation.getDtReservation(), uneReservation.getNbJoueurs());
            }
        }

        private void bt_gestionReservation_informations_delete_Click(object sender, EventArgs e)
        {
            //Si l'utilisateur sélectionne une ligne 
            if (dgv_gestionReservation_informations.SelectedRows.Count == 1)
            {
                //Dialog box de confirmation de choix avant la suppression
                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer la réservation ?", "Suppresssion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedrowindex = dgv_gestionReservation_informations.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgv_gestionReservation_informations.Rows[selectedrowindex];

                    int numeroReservation = Convert.ToInt32(selectedRow.Cells[0].Value);

                    //Supprime l'adhérent de la liste à l'index où se trouve le num Adhérent correspondant (mais ne supprime pas l'adhérent)
                    GestionClub.getToutesLesReservations().RemoveAt(GestionClub.getIndexOfReserv(numeroReservation));
                    MessageBox.Show("Vous avez bien supprimé la réservation");

                    Form_gestionReservation_informations.ActiveForm.Close();
                }
            }
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne correspondant à la réservation que vous souhaitez supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_gestionReservation_informations_modif_Click(object sender, EventArgs e)
        {
            if (dgv_gestionReservation_informations.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_gestionReservation_informations.SelectedCells[0].RowIndex;
                Form_gestionReservation_informations.ActiveForm.Close();
                Form_gestionReservation_modif Form_gestionReservation_Modif = new Form_gestionReservation_modif(Convert.ToInt32(dgv_gestionReservation_informations.Rows[selectedRowIndex].Cells[0].Value.ToString()));
                Form_gestionReservation_Modif.ShowDialog();
            }
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne de la réservation dont vous souhaitez modifier les informations. \n \n Pour cela utiliser la flèche au début de la ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
