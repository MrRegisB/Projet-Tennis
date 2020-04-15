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
    public partial class Form_gestionReservation : Form
    {
        public Form_gestionReservation()
        {
            InitializeComponent();
        }

        private void bt_gestionReservation_achat_Click(object sender, EventArgs e)
        {
            Form_gestionReservation_achat Form_gestionReservation_Achat = new Form_gestionReservation_achat();
            Form_gestionReservation_Achat.ShowDialog();
        }

        private void bt_gestionReservation_reservation_Click(object sender, EventArgs e)
        {
            GestionReservation.Form_gestionReservation_reservation Form_gestionReservation_Reservation = new GestionReservation.Form_gestionReservation_reservation();
            Form_gestionReservation_Reservation.ShowDialog();
        }

        private void bt_gestionReservation_informations_Click(object sender, EventArgs e)
        {
            Form_gestionReservation_informations form_gestionReservation_informations = new Form_gestionReservation_informations();
            form_gestionReservation_informations.ShowDialog();
        }
    }
}
