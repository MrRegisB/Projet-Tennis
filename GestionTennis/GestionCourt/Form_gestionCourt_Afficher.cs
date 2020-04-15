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
    public partial class Form_gestionCourt_Afficher : Form
    {
        public Form_gestionCourt_Afficher()
        {
            InitializeComponent();
        }

        private void Form_gestionCourt_Afficher_Load(object sender, EventArgs e)
        {
            foreach (Court unCourt in GestionClub.getTousLesCourts())
            {
                dgv_gestionCourt_afficher.Rows.Add(unCourt.getNumero(),
                                                   unCourt.getNbPlaces());
            }
        }

        private void bt_gestionCourt_afficher_delete_Click(object sender, EventArgs e)
        {
            //Si l'utilisateur sélectionne une ligne 
            if (dgv_gestionCourt_afficher.SelectedRows.Count == 1)
            {
                //Dialog box de confirmation de choix avant la suppression
                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer le court ?", "Suppresssion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedrowindex = dgv_gestionCourt_afficher.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgv_gestionCourt_afficher.Rows[selectedrowindex];

                    int numeroCourt = Convert.ToInt32(selectedRow.Cells[0].Value);

                    //Supprime l'adhérent de la liste à l'index où se trouve le num Adhérent correspondant (mais ne supprime pas l'adhérent)
                    GestionClub.getTousLesCourts().RemoveAt(GestionClub.getIndexOfCourt(numeroCourt));

                    MessageBox.Show("Vous avez bien supprimé le court");
                    Form_gestionCourt_Afficher.ActiveForm.Close();
                }
            }
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne correspondant au court que vous souhaitez supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_gestionCourt_afficher_modif_Click(object sender, EventArgs e)
        {
            if (dgv_gestionCourt_afficher.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgv_gestionCourt_afficher.SelectedCells[0].RowIndex;
                Form_gestionCourt_modif.ActiveForm.Close();
                Form_gestionCourt_modif form_gestionCourt_modif = new Form_gestionCourt_modif(Convert.ToInt32(dgv_gestionCourt_afficher.Rows[selectedRowIndex].Cells[0].Value.ToString()));
                form_gestionCourt_modif.ShowDialog();   
            }
            //Si aucune ligne n'a été sélectionnée 
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner la ligne du court dont vous souhaitez modifier les informations. \n \n Pour cela utiliser la flèche au début de la ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }
    }
}
