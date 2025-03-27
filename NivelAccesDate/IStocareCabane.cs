using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareCabane : IStocareFactory
    {
        List<Cabane> GetCabane();
        Cabane GetCabana(int id);
        bool AddCabana(Cabane c);

        bool UpdateCabana(Cabane c);
    }
}
