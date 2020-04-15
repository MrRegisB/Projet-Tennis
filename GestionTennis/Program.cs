using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
namespace GestionTennis
{
    [Serializable]
    public class Adherent
    {
        private int numero;
        private string nom;
        private string prenom;
        private DateTime dtNaissance;
        private string numTel;
        private string mail;
        private string classement;
        private DateTime dtFinAdhesion;
        private int nbReservation;

        //Getters 
        public int getNumero() { return this.numero; }
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }
        public DateTime getDtNaissance() { return this.dtNaissance; }
        public string getNumTel() { return this.numTel; }
        public string getMail() { return this.mail; }
        public string getClassement() { return this.classement; }
        public DateTime getDtFinAdhesion() { return this.dtFinAdhesion; }
        public int getNbReservation() { return this.nbReservation; }

        //Setters 
        public int setNumero(int unNumero) { return this.numero = unNumero;  }
        public string setNom(string unNom) { return this.nom = unNom; }
        public string setPrenom(string unPrenom) { return this.prenom = unPrenom; }
        public DateTime setDtNaissance(DateTime uneDtNaissance) { return this.dtNaissance = uneDtNaissance; }
        public string setNumTel(string unNumTel) { return this.numTel = unNumTel; }
        public string setMail(string unMail) { return this.mail = unMail; }
        public string setClassement(string unClassement) { return this.classement = unClassement; }
        public DateTime setDtFinAdhesion(DateTime uneDtFinAdhesion) { return this.dtFinAdhesion = uneDtFinAdhesion; }
        public int setNbReservation(int unNbReservation) { return this.nbReservation = unNbReservation; }

        //Constructeur
        public Adherent(string unNom, string unPrenom, DateTime uneDtNaissance, string unNumTel, string unMail, string unClassement, DateTime uneDtFinAdhesion) 
        {
            //On remplit avec le dernier numéro d'ahérent qui n'est pas encore attribué
            this.numero = GestionClub.getDernierNumAdherent();
            //On incrémentente le prochain numéro à assigner
            GestionClub.setDernierNumAdherent(GestionClub.getDernierNumAdherent() + 1);

            this.nom = unNom;
            this.prenom = unPrenom;
            this.dtNaissance = uneDtNaissance;
            this.numTel = unNumTel;
            this.mail = unMail;
            this.classement = unClassement;
            this.dtFinAdhesion = uneDtFinAdhesion;
            this.nbReservation = 0;

            GestionClub.getTousLesAdherents().Add(this);
        }
        //Alias 
        public int Numero 
        {
            get 
            {
                return this.numero;
            }
        }
        public string EtatCivil
        {
            get 
            {
                return this.nom + " " + this.prenom;
            }
        }

        
    }
    [Serializable]
    public class Court
    {
        private int numero;
        private int nbPlaces;

        //Getters 
        public int getNumero() { return this.numero; }
        public int getNbPlaces() { return this.nbPlaces; }

        //Setters 
        public int setNumero(int unNumero) { return this.numero = unNumero; }
        public int setNbPLaces(int unNbPlaces) { return this.nbPlaces = unNbPlaces; }

        //Constructeur
        public Court(int unNbPlaces)
        {
            //On remplit avec le dernier numéro de court qui n'est pas encore attribué
            this.numero = GestionClub.getDernierNumCourt();
            //On incrémentente le prochain numéro à assigner
            GestionClub.setDernierNumCourt(GestionClub.getDernierNumCourt() + 1);

            this.nbPlaces = unNbPlaces;

            GestionClub.getTousLesCourts().Add(this);
        }
        //Alias 
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        public string Nom
        {
            get
            {
                return "Court n°" + this.numero;
            }
        }

    }
    [Serializable]
    public class Reservation
    {

        private int numeroReservation;
        private Adherent adherentReserve;
        private Court courtReserve;
        private DateTime dtReservation;
        private int nbJoueurs;

        //Getters
        public int getNumeroReservation() { return this.numeroReservation; }
        public Adherent getAdherentReserve(){ return this.adherentReserve; }
        public Court getCourtReserve() { return this.courtReserve; }
        public DateTime getDtReservation() { return this.dtReservation; }
        public int getNbJoueurs() { return this.nbJoueurs; }
        
        //Setters
        public int setNumeroReservation(int unNumReserv) { return this.numeroReservation = unNumReserv; }
        public Adherent setAdherentReserve(Adherent unAdherent) { return this.adherentReserve = unAdherent; }
        public Court setCourtReserve(Court unCourt) { return this.courtReserve = unCourt;}
        public DateTime setDtReservation(DateTime uneDtReservation) { return this.dtReservation = uneDtReservation; }
        public int setNbJoueurs(int unNbJoueurs) { return this.nbJoueurs = unNbJoueurs; }

        //Constructeur
        public Reservation(Adherent unAdherent, Court unCourt, DateTime uneDtReservation,int unNbJoueurs) 
        {
            this.numeroReservation = GestionClub.getDernierNumReserv();
            GestionClub.setDernierNumReserv(GestionClub.getDernierNumReserv() + 1);
            
            this.adherentReserve = unAdherent;
            this.courtReserve = unCourt;
            this.dtReservation = uneDtReservation;
            this.nbJoueurs = unNbJoueurs;
            this.adherentReserve.setNbReservation(this.adherentReserve.getNbReservation()-1);

            GestionClub.getToutesLesReservations().Add(this);
        }
    }

    public static class GestionClub 
    {
        private static List<Adherent> tousLesAdherents = new List<Adherent>();
        private static List<Court> tousLesCourts = new List<Court>();
        private static List<Reservation> toutesLesReservations = new List<Reservation>();
        private static int dernierNumAdherent=0;
        private static int dernierNumCourt=0;
        private static int dernierNumReserv=0;

        //Tableaux de paramètres :

        //Tableau de nombre du lot de nombre de places achetables
        private static int[] nbPlacesAchetables = new int[] { 10, 20, 50 };
        //Tableau du nombre de joueurs pouvant jouer sur un court
        private static int[] nbJoueursCourt = new int[] { 2, 4 };

        private static string[] classementTennis = new string[] { "Aucun", "15/A", "15/B", "15/C", "Champion" };
        
        //Getters
        public static List<Adherent> getTousLesAdherents() { return tousLesAdherents; }
        public static List<Court> getTousLesCourts() { return tousLesCourts; }
        public static List<Reservation> getToutesLesReservations() { return toutesLesReservations; }
        public static int getDernierNumAdherent() { return dernierNumAdherent; }
        public static int getDernierNumCourt() { return dernierNumCourt; }
        public static int getDernierNumReserv() { return dernierNumReserv; }
        public static int[] getParamNbPlacesAchetables() { return nbPlacesAchetables; }
        public static int[] getParamNbJoueursCourt() { return nbJoueursCourt; }
        public static string[] getParamClassement() { return classementTennis; }


        //Setters 
        public static int setDernierNumAdherent(int unDernierNumAdherent) { return dernierNumAdherent = unDernierNumAdherent; }
        public static int setDernierNumCourt(int unDernierNumCourt) { return dernierNumCourt = unDernierNumCourt; }
        public static int setDernierNumReserv(int unDernierNumReserv) { return dernierNumReserv = unDernierNumReserv; }

        //Permet de retrouver l'index de l'adherent dans la liste tousLesAdherents avec le numéro d'adhérent fournit
        public static int getIndexOfAdherent(int numeroAdherent)
         {
            //Delegation de fonction ?
             int i = 0;
             bool trouve = false;
             while (i <= tousLesAdherents.Count && trouve == false)
             {
                 if (tousLesAdherents[i].getNumero() == numeroAdherent)
                 {
                     trouve = true;

                 }
                 else
                 {
                     i++;
                 }

             }
             if (trouve == false)
             {
                 //Code d'erreur 
                 return -1;
             }
             else
             {
                 return i;
             }
         }
        //Permet de retrouver l'index de lu Court dans la liste tousLesCourts avec le numéro de court fournit
        public static int getIndexOfCourt(int numCourt)
        {
            //Delegation de fonction ?
            int i = 0;
            bool trouve = false;
            while (i <= tousLesAdherents.Count && trouve == false)
            {
                if (tousLesCourts[i].getNumero() == numCourt)
                {
                    trouve = true;
                }
                else 
                {
                    i++;
                }

            }
            if (trouve == false)
            {
                //Code d'erreur 
                return -1;
            }
            else
            {
                return i;
            }
        }
        public static int getIndexOfReserv(int numReserv)
        {
            //Delegation de fonction ?
            int i = 0;
            bool trouve = false;
            while (i <= toutesLesReservations.Count && trouve == false)
            {
                if (toutesLesReservations[i].getNumeroReservation() == numReserv)
                {
                    trouve = true;
                }
                else
                {
                    i++;
                }

            }
            if (trouve == false)
            {
                //Code d'erreur 
                return -1;
            }
            else
            {
                return i;
            }
        }

        public static void loadingCombobox(ComboBox combobox, List<Object> liste, string displayMember, string valueMember)
        {
            combobox.DataSource = liste;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;

            //On désélectionne les valeurs (ici le DataSource séléctionne par défaut la première valeur de la liste)
            combobox.SelectedIndex = -1;
        }

        public static List<int> getCourtsDispos(DateTime dateAndHour)
        {
            List<int> courtsDispos = new List<int>();
            if (toutesLesReservations.Count > 0)
            {
                bool trouve = false; 
                int i=0;
                foreach (Court unCourt in tousLesCourts)
                {
                    trouve = false;
                    i = 0;
                    while (i < toutesLesReservations.Count && trouve==false)
                    {
                        if (unCourt.getNumero() == toutesLesReservations[i].getCourtReserve().getNumero() && toutesLesReservations[i].getDtReservation() == dateAndHour)
                        {
                            trouve = true;
                        }
                        i++;
                    }
                    if (trouve == false)
                    {
                        courtsDispos.Add(unCourt.getNumero());
                    }
                }
            }
            else
            {
                foreach (Court unCourt in tousLesCourts)
                {
                    courtsDispos.Add(unCourt.getNumero());
                }
            }
            return courtsDispos;
        }
        public static List<string> controleSaisieAdherent(string nom, string prenom, string phoneNumber, string email)
        {

            List<string> messagesErreur = new List<string>();

            Regex onlyAlphabeticCaract = new Regex("^[a-zA-Z]+$");

            onlyAlphabeticCaract.IsMatch(nom);

            if (!onlyAlphabeticCaract.IsMatch(nom))
            {

                messagesErreur.Add("Veuillez saisir un nom corect");

            }
            Regex onlyAlphabeticCaractPren = new Regex("^[a-zA-Z]+$");
            if (!onlyAlphabeticCaractPren.IsMatch(prenom))
            {

                messagesErreur.Add("Veuillez saisir un prénom corect");

            }
            Regex phoneNumberRegex = new Regex(@"(?:(?:\+|00)33|0)\s*[1-9](?:[\s.-]*\d{2}){4}");

            if (!phoneNumberRegex.IsMatch(phoneNumber))
            {

                messagesErreur.Add("Veuillez saisir un numéro de téléphone correct");

            }
            try
            {
                var testEmail = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                messagesErreur.Add("Veuillez saisir une adresse mail correcte");
            }
            return messagesErreur;

        }
        public static void quitter()
        {
            BinaryFormatter format = new BinaryFormatter();
            Stream flux = new FileStream("../../save.bin", FileMode.Create, FileAccess.Write);
            format.Serialize(flux, tousLesAdherents);
            format.Serialize(flux, tousLesCourts);
            format.Serialize(flux, toutesLesReservations);
            format.Serialize(flux, dernierNumAdherent);
            format.Serialize(flux, dernierNumCourt);
            format.Serialize(flux, dernierNumReserv);
            flux.Close();
            Application.Exit();
        }
        public static void demarrer()
        {
            BinaryFormatter format = new BinaryFormatter();
            Stream flux = new FileStream("../../save.bin", FileMode.OpenOrCreate, FileAccess.Read);
            tousLesAdherents = (List<Adherent>)format.Deserialize(flux);
            tousLesCourts = (List<Court>)format.Deserialize(flux);
            toutesLesReservations = (List<Reservation>)format.Deserialize(flux);
            dernierNumAdherent = (int)format.Deserialize(flux);
            dernierNumCourt = (int)format.Deserialize(flux);
            dernierNumReserv = (int)format.Deserialize(flux);
            flux.Close();
        }

    }

    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestionClub.demarrer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_menu());
        }
    }
}
