using System;
using System.Data;

namespace LibrarieModele
{
    public class Cabane
    {
        public int ID_Cabana { get; set; }
        public string Nume_Cabana { get; set; }
        public string Localitatea { get; set; }
        public int Numar_Camere { get; set; }
        public float Tarif_Pe_Noapte { get; set; }

        public Cabane()
        { }

        public Cabane(int id_cabana, string nume_cabana, string localitatea, int numar_camere, float tarif_pe_noapte)
        {
            ID_Cabana = id_cabana;
            Nume_Cabana = nume_cabana;
            Localitatea = localitatea;
            Numar_Camere = numar_camere;
            Tarif_Pe_Noapte = tarif_pe_noapte;
        }

        public Cabane(DataRow linieDB)
        {
            ID_Cabana = Convert.ToInt32(linieDB["id_cabana"].ToString());
            Nume_Cabana = linieDB["nume_cabana"].ToString();
            Localitatea = linieDB["localitatea"].ToString();
            Numar_Camere = Convert.ToInt32(linieDB["numar_camere"].ToString());
            Tarif_Pe_Noapte = Convert.ToInt32(linieDB["tarif_pe_noapte"].ToString());
        }
    }
}
