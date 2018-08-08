using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Classes
{
    public abstract class User
    {
        public int IdCarte { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
		public string MotDePasse { get; set; }
		public int NbAvertissement { get; set; }
        public bool BlackListed { get; set; }

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
