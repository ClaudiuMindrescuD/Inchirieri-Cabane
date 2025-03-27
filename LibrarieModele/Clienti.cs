using System;
using System.Data;

namespace LibrarieModele
{
    public class Clienti
    {
        public int ID_Client { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int CNP { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }


        public Clienti()
        { }
        public Clienti(int id_client, string nume, string prenume, int cnp, string email, int telefon)
        {
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Telefon = telefon;
            ID_Client = id_client;
            Email = email;
        }

        public Clienti(DataRow linieBD)
        {
            ID_Client = Convert.ToInt32(linieBD["id_client"].ToString());
            Nume = linieBD["nume"].ToString();
            Prenume = linieBD["prenume"].ToString();
            CNP = Convert.ToInt32(linieBD["cnp"].ToString());
            Email = linieBD["email"].ToString();
            Telefon = Convert.ToInt32(linieBD["telefon"].ToString());
        }
    }
}
