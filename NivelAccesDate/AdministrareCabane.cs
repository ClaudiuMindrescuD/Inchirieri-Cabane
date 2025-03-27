using System.Collections.Generic;
using System.Data;
using LibrarieModele;

using Oracle.ManagedDataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareCabane : IStocareCabane
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Cabane> GetCabane()
        {
            var result = new List<Cabane>();
            var dsCabane = SqlDBHelper.ExecuteDataSet("select * from cabane", CommandType.Text);

            foreach (DataRow linieDB in dsCabane.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Cabane(linieDB));
            }
            return result;
        }

        public Cabane GetCabana(int id)
        {
            Cabane result = null;
            var dsCabane = SqlDBHelper.ExecuteDataSet("select * from cabane where ID_Cabana = :ID_Cabana", CommandType.Text,
                new OracleParameter(":ID_Cabana", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsCabane.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsCabane.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Cabane(linieDB);
            }
            return result;
        }

        public bool AddCabana(Cabane cab)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO cabane VALUES (seq_cabane.nextval, :ID_Cabana, :Nume_Cabana, :Localitatea, :Numar_Camere, :Tarif_Pe_Noapte)", CommandType.Text,
                new OracleParameter(":ID_Cabana", OracleDbType.Int32, cab.ID_Cabana, ParameterDirection.Input),
                new OracleParameter(":Nume_Cabana", OracleDbType.NVarchar2, cab.Nume_Cabana, ParameterDirection.Input),
                new OracleParameter(":Localitatea", OracleDbType.NVarchar2, cab.Localitatea, ParameterDirection.Input),
                new OracleParameter(":Numar_Camere", OracleDbType.Int32, cab.Numar_Camere, ParameterDirection.Input),
                new OracleParameter(":Tarif_Pe_Noapte", OracleDbType.Int64, cab.Tarif_Pe_Noapte, ParameterDirection.Input));
        }

        public bool UpdateCabana(Cabane cab)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE cabane set ID_Cabana = :ID_Cabana, Nume_Cabana = :Nume_Cabana, Localitatea = :Localitatea, Numar_Camere = :Numar_Camere, Tarif_Pe_Noapte = :Tarif_Pe_Noapte where ID_Cabana = :ID_Cabana", CommandType.Text,
                new OracleParameter(":ID_Cabana", OracleDbType.Int32, cab.ID_Cabana, ParameterDirection.Input),
                new OracleParameter(":Nume_Cabana", OracleDbType.NVarchar2, cab.Nume_Cabana, ParameterDirection.Input),
                new OracleParameter(":Localitatea", OracleDbType.NVarchar2, cab.Localitatea, ParameterDirection.Input),
                new OracleParameter(":Numar_Camere", OracleDbType.Int32, cab.Numar_Camere, ParameterDirection.Input),
                new OracleParameter(":Tarif_Pe_Noapte", OracleDbType.Int64, cab.Tarif_Pe_Noapte, ParameterDirection.Input));
        }
    }
}
