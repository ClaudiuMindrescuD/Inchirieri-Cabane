using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace InterfataUtilizator
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = "BazaDateOracle";
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Cabane))
                        {
                            return new AdministrareCabane();
                        }
                        if (tipEntitate == typeof(Clienti))
                        {
                            return new AdministrareClienti();
                        }
                        if (tipEntitate == typeof(Rezervari))
                        {
                            return new AdministrareRezervari();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
