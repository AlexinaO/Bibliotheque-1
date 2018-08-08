using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public enum NbOuvragesEmpruntes
    {
        UN = 1,
        DEUX = 2
    };

    public class Emprunte
    {
        public DateTime DateEmprunt { get; private set; }
        public User User { get; private set; }
        public Ouvrage[] OuvrageEmprunte { get; private set; }

        public Emprunte(DateTime dateEmprunt, User user, NbOuvragesEmpruntes nb)
        {
            DateEmprunt = dateEmprunt;
            User = user;
            OuvrageEmprunte = new Ouvrage[(int)nb];
        }

        // methode Effacer() efface la réservation quand l'user emprunte
        public void Effacer()
        {

        }
    }
}
