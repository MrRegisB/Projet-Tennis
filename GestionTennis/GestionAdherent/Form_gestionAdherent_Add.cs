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
    public partial class Form_gestionAdherent_Add : Form
    {
        public Form_gestionAdherent_Add()
        {
            InitializeComponent();
        }

        private void bt_gestionAdherent_Add_Valider_Click(object sender, EventArgs e)
        {
            //On oblige l'utilisateur à saisir au moins le nom et le prénom car ce sont les valeurs affichés dans les comboBox de l'appli
            if (tb_gestionAdherent_Add_nom.Text.ToString() == "" || tb_gestionAdherent_Add_prenom.Text.ToString() == "")
            {
                MessageBox.Show("Les champs nom et prénom doivent obligatoirement être remplis");
            }
            else
            {
                //Test pour afficher les valeurs de toutes les saisies
                //MessageBox.Show(tb_gestionAdherent_Add_nom.Text.ToString() + " " + tb_gestionAdherent_Add_prenom.Text.ToString() + " " + dtp_form_gestionAdherent_Add_ddn.Text.ToString() + " " + tb_gestionAdherent_Add_numTel.Text.ToString() + " " + tb_gestionAdherent_Add_mail.Text.ToString() + " " + cb_gestionAdherent_Add_classement.SelectedItem.ToString() + " " + dtp_gestionAdherent_Add_dtFinAdhesion.Value.ToString());
                try
                {
                    List<string> messagesErreur = GestionClub.controleSaisieAdherent(tb_gestionAdherent_Add_nom.Text, tb_gestionAdherent_Add_prenom.Text, tb_gestionAdherent_Add_numTel.Text, tb_gestionAdherent_Add_mail.Text);
                    if (messagesErreur.Count == 0)
                    {

                        Adherent adh1 = new Adherent(tb_gestionAdherent_Add_nom.Text,
                                                tb_gestionAdherent_Add_prenom.Text,
                                                Convert.ToDateTime(dtp_form_gestionAdherent_Add_ddn.Value.ToString()),
                                                tb_gestionAdherent_Add_numTel.Text,
                                                tb_gestionAdherent_Add_mail.Text,
                                                cb_gestionAdherent_Add_classement.SelectedItem.ToString(),
                                                Convert.ToDateTime(dtp_gestionAdherent_Add_dtFinAdhesion.Value.ToString()));


                        MessageBox.Show("Vous avez bien ajouté l'adhérent : " + tb_gestionAdherent_Add_nom.Text.ToString() + " " + tb_gestionAdherent_Add_prenom.Text.ToString());

                        //Remise de tous les champs à vide, ou à leur valeur par défaut
                        tb_gestionAdherent_Add_nom.Clear();
                        tb_gestionAdherent_Add_prenom.Clear();
                        tb_gestionAdherent_Add_numTel.Clear();
                        tb_gestionAdherent_Add_mail.Clear();
                        cb_gestionAdherent_Add_classement.SelectedIndex = -1;
                        dtp_form_gestionAdherent_Add_ddn.Value = DateTime.Today;
                        dtp_gestionAdherent_Add_dtFinAdhesion.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show(tb_gestionAdherent_Add_prenom.Text);
                        string messageErreur= "";
                        foreach (string erreur in messagesErreur)
                        {
                            messageErreur += "\n" +erreur;
                        }
                        MessageBox.Show(messageErreur);
                    }
                }
                catch
                {
                    MessageBox.Show("Saisie invalide, tous les champs ne sont pas remplis, ou correctement remplis");
                }
            }
        }

        private void Form_gestionAdherent_Add_Load(object sender, EventArgs e)
        {
            foreach (string classement in GestionClub.getParamClassement())
            {
                cb_gestionAdherent_Add_classement.Items.Add(classement);
            }
        }
    }
}
