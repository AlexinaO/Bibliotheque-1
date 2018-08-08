using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public sealed class Professeur : User
    {
        public string Departement { get; private set; }
        public string Profession { get; private set; }

        public void Recommander(List<Ouvrage> ouvragesARecommander, bool recommandation)
        {
            foreach (Ouvrage ouvrage in ouvragesARecommander)
                ouvrage.Recommandations.Add(recommandation);
        }
    }
}
