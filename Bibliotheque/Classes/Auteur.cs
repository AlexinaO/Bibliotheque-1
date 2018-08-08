using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public sealed class Auteur
    {
		public Auteur(string nom, string prenom)
		{
			Nom = nom;
			Prenom = prenom;
			Ouvrages = new List<Ouvrage>();
		}
        public int ID { get;  set; }
        public string Nom { get;  set; }
        public string Prenom { get;  set; }

        public List<Ouvrage> Ouvrages { get;  set; }

    }
}
