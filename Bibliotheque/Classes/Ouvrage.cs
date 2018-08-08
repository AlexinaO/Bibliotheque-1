﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public abstract class Ouvrage
    {
        public int IdOuvrage { get; private set; }
        public string Filiere { get; private set; }
        public string Categorie { get; private set; }
        public string Discipline { get; private set; }
        public string Titre { get; private set; }

    }
}