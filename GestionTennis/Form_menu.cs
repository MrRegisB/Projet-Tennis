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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void bt_gestionAdherent_Click(object sender, EventArgs e)
        {
            Form_gestionAdherent form_GestionAdherent = new Form_gestionAdherent();
            form_GestionAdherent.ShowDialog();
        }

        private void bt_gestionCourts_Click(object sender, EventArgs e)
        {
            Form_gestionCourt form_GestionCourt = new Form_gestionCourt();
            form_GestionCourt.ShowDialog();
        }

        private void bt_gestionReservation_Click(object sender, EventArgs e)
        {
            Form_gestionReservation form_GestionReservation = new Form_gestionReservation();
            form_GestionReservation.ShowDialog();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            GestionClub.quitter();
        }
    }
}
