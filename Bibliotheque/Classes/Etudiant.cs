using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public sealed class Etudiant : User
    {
        public string Filiere { get; private set; }
        
        public void Noter(List<Ouvrage> ouvragesANoter, NoteOuvrage note)
        {
			foreach (Ouvrage ouvrage in ouvragesANoter)
				ouvrage.Notations.Add(note);
        }
    }
}
