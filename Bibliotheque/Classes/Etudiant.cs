using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public sealed class Etudiant : User
    {
		public Etudiant(string nom, string prenom)
		{
			Nom = nom;
			Prenom = prenom;
		}

        public string Filiere { get;  set; }
        
        public void Noter(List<Livre> ouvragesANoter, NoteOuvrage note)
        {
			foreach (Livre ouvrage in ouvragesANoter)
				ouvrage.Notations.Add(note);
        }
    }
}
