using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.Classes;

namespace Bibliotheque
{
	class Program
	{
		static List<Ouvrage> ouvrages = new List<Ouvrage>(); // ok
		static List<Auteur> auteurs = new List<Auteur>(); // ok
		static List<Livre> livres = new List<Livre>(); // ok
		static List<Article> articles = new List<Article>();
		static List<CD> cds = new List<CD>();
		static List<User> users = new List<User>(); // ok
		static List<Professeur> profs = new List<Professeur>(); // ok
		static List<Etudiant> etudiants = new List<Etudiant>(); // ok

		static void initialisation()
		{
			livres.Add(new Livre("Sciences", "Chimie", "Expériences", "La chimie en folie"));
			livres.Add(new Livre("Sciences", "Maths", "Expériences", "Les maths en folie"));
			livres.Add(new Livre("Litterature", "Classique", "XIXème", "Le comte de Montecristo"));
			cds.Add(new CD());
			ouvrages.Concat(livres);
			//ouvrages.Concat(cds);

			auteurs.Add(new Auteur("Alexandre", "Dumas"));
			auteurs.ElementAt(0).Ouvrages.Add(livres.ElementAt(2));
			livres.ElementAt(2).Auteurs.Add(auteurs.ElementAt(0));

			profs.Add(new Professeur("Martin", "Toto"));
			profs.Add(new Professeur("Condat", "Maxime"));
			etudiants.Add(new Etudiant("Perroud", "Romain"));
			etudiants.Add(new Etudiant("Fabre", "Antoine"));
			//users.Concat(profs);
			//users.Concat(etudiants);
		}

		static void Main(string[] args)
		{
			initialisation();

			foreach (var item in livres)
			{
				Console.Write($"{item.Titre}");
				foreach (var auteur in item.Auteurs)
					Console.Write($" de  {auteur.Nom} {auteur.Prenom}");
				foreach (var note in item.Notations)
					Console.Write($" et une note de {note.ToString()}");
				Console.WriteLine("");
			}

			foreach (var item in cds)
				Console.WriteLine("\n" + "un cd " + item.Titre);

			etudiants.ElementAt(1).Noter(livres, NoteOuvrage.EXCELLENT);

			foreach(var item in livres)
			{
				Console.Write($"{item.Titre}");
				foreach (var auteur in item.Auteurs)
					Console.Write($" de  {auteur.Nom} {auteur.Prenom}");
				foreach (var note in item.Notations)
					Console.Write($" et une note de {note.ToString()}");
				Console.WriteLine("");
			}
		}
	}
}
