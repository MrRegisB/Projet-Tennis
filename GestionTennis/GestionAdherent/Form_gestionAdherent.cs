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
    public partial class Form_gestionAdherent : Form
    {
        public Form_gestionAdherent()
        {
            InitializeComponent();
        }

        private void bt_gestionAdherent_Add_Click(object sender, EventArgs e)
        {
            Form_gestionAdherent_Add form_GestionAdherent_Add = new Form_gestionAdherent_Add();
            form_GestionAdherent_Add.ShowDialog();
        }

        private void bt_gestionAdherent_afficher_Click(object sender, EventArgs e)
        {
            Form_gestionAdherent_Afficher form_GestionAdherent_Afficher = new Form_gestionAdherent_Afficher();
            form_GestionAdherent_Afficher.ShowDialog();
        }
    }
}
