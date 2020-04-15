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
    public partial class Form_gestionCourt : Form
    {
        public Form_gestionCourt()
        {
            InitializeComponent();
        }

        private void bt_gestionCourt_add_Click(object sender, EventArgs e)
        {
            Form_gestionCourt_add from_GestionCourt_add = new Form_gestionCourt_add();
            from_GestionCourt_add.ShowDialog();
        }

        private void bt_gestionCourt_Afficher_Click(object sender, EventArgs e)
        {
            Form_gestionCourt_Afficher from_GestionCourt_afficher = new Form_gestionCourt_Afficher();
            from_GestionCourt_afficher.ShowDialog();
        }
    }
}
