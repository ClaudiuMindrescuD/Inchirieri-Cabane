using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareClienti : IStocareFactory
    {
        List<Clienti> GetClienti();
        Clienti GetClient(int id);
        bool AddClient(Clienti m);

        bool UpdateClient(Clienti m);
    }
}
