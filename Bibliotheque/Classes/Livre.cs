using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public sealed class Livre : Ouvrage
    {
		public Livre()
		{
			Titre = "tritre manquant";
			Auteurs = new List<Auteur>();
			Notations = new List<NoteOuvrage>();
			Recommandations = new List<bool>();
			Commentaires = new List<string>();

		}

		public Livre(string filiere, string categorie, string discipline, string titre)
		{
			Filiere = filiere;
			Categorie = categorie;
			Discipline = discipline;
			Titre = titre;
			Auteurs = new List<Auteur>();
			Notations = new List<NoteOuvrage>();
			Recommandations = new List<bool>();
			Commentaires = new List<string>();
		}
	}
}
