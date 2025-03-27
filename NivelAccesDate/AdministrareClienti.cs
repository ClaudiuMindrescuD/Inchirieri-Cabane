using LibrarieModele;

using Oracle.ManagedDataAccess.Client;

using System.Collections.Generic;
using System.Data;


namespace NivelAccesDate
{
    public class AdministrareClienti : IStocareClienti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Clienti> GetClienti()
        {
            var result = new List<Clienti>();
            var dsClienti = SqlDBHelper.ExecuteDataSet("select * from Clienti", CommandType.Text);

            foreach (DataRow linieBD in dsClienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Clienti(linieBD));
            }
            return result;
        }

        public Clienti GetClient(int id)
        {
            Clienti result = null;
            var dsClienti = SqlDBHelper.ExecuteDataSet("select * from Clienti where ID_Client = :ID_Client", CommandType.Text,
                new OracleParameter(":ID_Client", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsClienti.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsClienti.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Clienti(linieBD);
            }
            return result;
        }

        public bool AddClient(Clienti c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into Clienti VALUES (seq_Clienti.nextval, :ID_Client, :Nume, :Prenume, :CNP, :Email, :Telefon)", CommandType.Text,
                new OracleParameter(":ID_Clienti", OracleDbType.Int32, c.ID_Client, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.NVarchar2, c.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, c.Prenume, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.Int64, c.CNP, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Int64, c.Telefon, ParameterDirection.Input)
            );
        }

        public bool UpdateClient(Clienti c)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Clienti set ID_Client = :ID_Client, Nume = :Nume, Prenume =:Prenume, CNP =:CNP, Email = :Email. Telefon = :Telefon where ID_Client=:ID_Client", CommandType.Text,
                new OracleParameter(":ID_Clienti", OracleDbType.Int32, c.ID_Client, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.NVarchar2, c.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.NVarchar2, c.Prenume, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.Int64, c.CNP, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Int64, c.Telefon, ParameterDirection.Input)
            );
        }
    }
}
