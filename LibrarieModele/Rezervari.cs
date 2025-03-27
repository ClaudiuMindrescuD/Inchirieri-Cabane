using System;
using System.Data;

namespace LibrarieModele
{
    public class Rezervari
    {
        public int ID_Rezervari { get; set; }
        public int ID_Cabana { get; set; }
        public int ID_Client { get; set; }
        public DateTime Data_CheckIn { get; set; }
        public DateTime Data_CheckOut { get; set; }

        public virtual Cabane Cabane { get; set; }
        public virtual Clienti Clienti { get; set; }
        public Rezervari()
        { }

        public Rezervari(int id_rezervari, int id_cabana, int client, DateTime data_checkin, DateTime data_checkput)
        {
            ID_Rezervari = id_rezervari;
            ID_Cabana = id_cabana;
            ID_Client = client;
            Data_CheckIn = data_checkin;
            Data_CheckOut = data_checkput;
        }

        public Rezervari(DataRow linieBD)
        {
            ID_Rezervari = Convert.ToInt32(linieBD["id_rezervari"].ToString());
            ID_Cabana = Convert.ToInt32(linieBD["id_cabana"].ToString());
            ID_Client = Convert.ToInt32(linieBD["id_client"].ToString());
            Data_CheckIn = Convert.ToDateTime(linieBD["data_checkin"].ToString());
            Data_CheckOut = Convert.ToDateTime(linieBD["data_checkout"].ToString());
        }
    }
}
