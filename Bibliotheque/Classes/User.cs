using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public abstract class User
    {
        public int IdCarte { get;  set; }
        public string Nom { get;  set; }
        public string Prenom { get;  set; }
        public string Email { get;  set; }
        public string MotDePasse { get;  set; }
        public int NbAvertissement { get;  set; }
        public bool BlackListed { get;  set; }

        public List<Ouvrage> Consulter(string recherche, List<Ouvrage> OuvragesDisponibles)
        {
            var requete = from element in OuvragesDisponibles
                          where element.Titre.Contains(recherche)
                          select element;
            return requete.ToList();
            /*return (from element in OuvragesDisponibles
                    where element.Titre.Contains(recherche)
                    select element).ToList();*/
        }

        public void Commenter(List<Ouvrage> ouvrageACommenter, List<string> commentaires)
        {
            for (var i = 0; i < ouvrageACommenter.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(commentaires.ElementAt(i)))
                    ouvrageACommenter.ElementAt(i).Commentaires.Add(commentaires.ElementAt(i));
            }
        }

        public List<string> Reserver(List<Ouvrage> ouvragesAReserver)
        {
            List<string> reponsesReservations = new List<string>();

            for (var i = 0; i < ouvragesAReserver.Count; i++)
            {
                string message;
                if (ouvragesAReserver.ElementAt(i).ReservePar == null)
                {
                    ouvragesAReserver.ElementAt(i).ReservePar = this;
                    message = $"{ouvragesAReserver.ElementAt(i).Titre} est réservé !";
                }
                else
                    message = $"{ouvragesAReserver.ElementAt(i).Titre} est indisponible !";

                reponsesReservations.Add(message);
            }

            return reponsesReservations;
        }
    }

}
