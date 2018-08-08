using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public abstract class User
    {
        public int IdCarte { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public string Email { get; private set; }
		public string MotDePasse { get; private set; }
		public int NbAvertissement { get; private set; }
        public bool BlackListed { get; private set; }

        public void Consulter()
        {

        }

        public void Commenter()
        {

        }

        public void Reserver()
        { 
}
	}

}
