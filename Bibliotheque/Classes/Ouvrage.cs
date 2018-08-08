﻿using System;
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
        public Ouvrage()
        {
            Titre = "tritre manquant";
            Auteurs = new List<Auteur>();
			Notations = new List<NoteOuvrage>();
            Recommandations = new List<bool>();
            Commentaires = new List<string>();

		}

        public Ouvrage(string filiere, string categorie, string discipline, string titre)
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

        public int IdOuvrage { get; private set; }
        public string Filiere { get; private set; }
        public string Categorie { get; private set; }
        public string Discipline { get; private set; }
        public string Titre { get; private set; }

        public List<Auteur> Auteurs { get; private set; }
        
		public List<NoteOuvrage> Notations { get; private set; }

        public List<bool> Recommandations { get; private set; }

        public List<string> Commentaires { get; private set; }

        public User ReservePar { get; set; }

    }
}
