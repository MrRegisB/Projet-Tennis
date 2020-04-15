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
    public partial class Form_gestionAdherent_modif : Form
    {
        public Form_gestionAdherent_modif(int numAdherent)
        {
            int indexAdherent = GestionClub.getIndexOfAdherent(numAdherent);
            InitializeComponent();
            //On rempli un tb non visible par l'utilisateur pour pouvoir accéder au numéro de l'utilisateur dans tout le formulaire
            tb_gestionAdherent_modif_num.Text = numAdherent.ToString();
            //On rempli les champs avec les valeurs correspondantes au numéro d'adhérent fourni en paramètre
           
            tb_gestionAdherent_modif_nom.Text = GestionClub.getTousLesAdherents()[indexAdherent].getNom().ToString();
            tb_gestionAdherent_modif_prenom.Text = GestionClub.getTousLesAdherents()[indexAdherent].getPrenom().ToString();
            dtp_gestionAdherent_modif_ddn.Value = GestionClub.getTousLesAdherents()[indexAdherent].getDtNaissance();
            tb_gestionAdherent_modif_mail.Text = GestionClub.getTousLesAdherents()[indexAdherent].getMail().ToString();
            tb_gestionAdherent_modif_numTel.Text = GestionClub.getTousLesAdherents()[indexAdherent].getNumTel().ToString();
            cb_gestionAdherent_modif_classement.Text = GestionClub.getTousLesAdherents()[indexAdherent].getClassement();
            dtp_gestionAdherent_modif_dFinAdhesion.Value = GestionClub.getTousLesAdherents()[indexAdherent].getDtFinAdhesion();
        }

        private void Form_gestionAdherent_modif_Load(object sender, EventArgs e)
        {
            foreach (string classement in GestionClub.getParamClassement())
            {
                cb_gestionAdherent_modif_classement.Items.Add(classement);
            }
            
        }

        private void bt_gestionAdherent_modif_annuler_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toutes vos modifications vont-être perdues. Êtes vous sûr de vouloir annuler ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form_gestionAdherent_modif.ActiveForm.Close();
            }
        }

        private void bt_gestionAdherent_modif_valid_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir modifier les informations de l'adhérent ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                
                
                int indexAdherent = GestionClub.getIndexOfAdherent(Convert.ToInt32(tb_gestionAdherent_modif_num.Text));
                try
                {
                    
                    //On vérifie à chaque input que l'utilisateur a bien modifié la valeur avant de faire un setter
                    if (tb_gestionAdherent_modif_nom.Text != GestionClub.getTousLesAdherents()[indexAdherent].getNom())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setNom(tb_gestionAdherent_modif_nom.Text);
                    }

                    if (tb_gestionAdherent_modif_prenom.Text != GestionClub.getTousLesAdherents()[indexAdherent].getPrenom())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setPrenom(tb_gestionAdherent_modif_prenom.Text);
                    }

                    if (dtp_gestionAdherent_modif_ddn.Value != GestionClub.getTousLesAdherents()[indexAdherent].getDtNaissance())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setDtNaissance(dtp_gestionAdherent_modif_ddn.Value);
                    }

                    if (tb_gestionAdherent_modif_mail.Text != GestionClub.getTousLesAdherents()[indexAdherent].getMail())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setMail(tb_gestionAdherent_modif_mail.Text);
                    }

                    if (tb_gestionAdherent_modif_numTel.Text != GestionClub.getTousLesAdherents()[indexAdherent].getNumTel())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setNumTel(tb_gestionAdherent_modif_numTel.Text);
                    }

                    if (cb_gestionAdherent_modif_classement.Text != GestionClub.getTousLesAdherents()[indexAdherent].getClassement())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setClassement(cb_gestionAdherent_modif_classement.Text);
                    }

                    if (dtp_gestionAdherent_modif_dFinAdhesion.Value != GestionClub.getTousLesAdherents()[indexAdherent].getDtFinAdhesion())
                    {
                        GestionClub.getTousLesAdherents()[indexAdherent].setDtFinAdhesion(dtp_gestionAdherent_modif_dFinAdhesion.Value);
                    }
                    MessageBox.Show("Les modifications ont bien été effectuées");
                    Form_gestionAdherent_modif.ActiveForm.Close();
                    Form_gestionAdherent_Afficher form_gestionAdherent_afficher = new Form_gestionAdherent_Afficher();
                    form_gestionAdherent_afficher.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Un erreur a été détectée lors de la modification des informations. Veuillez vérifier que tous les champs soient bien remplis");
                }
            }
        }
    }
}
