using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
	public enum NoteOuvrage
	{
		MAUVAIS = 1,
		MOYEN,
		BIEN,
		EXCELLENT
	};

    public abstract class Ouvrage
    {
        public int IdOuvrage { get; set; }
        public string Filiere { get; set; }
        public string Categorie { get; set; }
        public string Discipline { get; set; }
        public string Titre { get; set; }

        public List<Auteur> Auteurs { get;  set; }
        
		public List<NoteOuvrage> Notations { get;  set; }

        public List<bool> Recommandations { get;  set; }

        public List<string> Commentaires { get;  set; }

        public User ReservePar { get; set; }
    }
}
