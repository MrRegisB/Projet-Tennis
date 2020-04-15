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
    public partial class Form_gestionAdherent_Afficher : Form
    {
        public Form_gestionAdherent_Afficher()
        {
            InitializeComponent();
        }

        private void Form_gestionAdherent_Afficher_Load(object sender, EventArgs e)
        {
            foreach (Adherent unAdherent in GestionClub.getTousLesAdherents())
            {
                dgv_gestionAdherent_Afficher.Rows.Add(unAdherent.getNumero(), 
                                                        unAdherent.getNom(), 
                                                        unAdherent.getPrenom(),
                                                        unAdherent.getDtNaissance().ToShortDateString(), 
                                                        unAdherent.getNumTel(),
                                                        unAdherent.getMail(),
                                                        unAdherent.getClassement().ToString(),
                                                        unAdherent.getDtFinAdhesion().ToShortDateString(),
                                                        unAdherent.getNbReservation());
                
            }

        }

        private void bt_gestionAdherent_afficher_delete_Click(object sender, EventArgs e)
        {
            //Si l'utilisateur sélectionne une ligne 
            if (dgv_gestionAdherent_Afficher.SelectedRows.Count == 1)
            {
                //Dialog box de confirmation de choix avant la suppression
                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer l'adhérent ?", "Suppresssion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRowIndex = dgv_gestionAdherent_Afficher.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgv_gestionAdherent_Afficher.Rows[selectedRowIndex];

                    int numeroAdherent = Convert.ToInt32(selectedRow.Cells[0].Value);

                    //Supprime l'adhérent de la liste à l'index où se trouve le num Adhérent correspondant (mais ne supprime pas l'adhérent)
                    GestionClub.getTousLesAdherents().RemoveAt(GestionClub.getIndexOfAdherent(numeroAdherent));

                    MessageBox.Show("Vous avez bien supprimé l'adhérent");
                    Form_gestionAdherent_Afficher.ActiveForm.Close();
                }
            }
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne correspondant à l'adhérent que vous souhaitez supprimer. \n \n Pour cela utiliser la flèche au début de la ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bt_gestionAdherent_afficher_modify_Click(object sender, EventArgs e)
        {

            if (dgv_gestionAdherent_Afficher.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_gestionAdherent_Afficher.SelectedCells[0].RowIndex;
                Form_gestionAdherent_modif.ActiveForm.Close();
                Form_gestionAdherent_modif form_GestionAdherent_Modif = new Form_gestionAdherent_modif(Convert.ToInt32(dgv_gestionAdherent_Afficher.Rows[selectedRowIndex].Cells[0].Value.ToString()));
                form_GestionAdherent_Modif.ShowDialog();
                
            }            
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne de l'adhérent dont vous souhaitez modifier les informations. \n \n Pour cela utiliser la flèche au début de la ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

    }
}
